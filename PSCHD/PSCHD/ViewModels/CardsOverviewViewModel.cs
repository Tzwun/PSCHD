using PSCHD.Core.Mvvm;
using PSCHD.Core;
using System.Collections.ObjectModel;
using Prism.Regions;
using Newtonsoft.Json;
using System.IO;
using PSCHD.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Threading;
using PSCHD.DB;
using Newtonsoft.Json.Linq;
using Unity;
using Prism.Commands;
using MaterialDesignExtensions.Controls;
using System;
using System.ComponentModel;

namespace PSCHD.ViewModels
{
    public class CardsOverviewViewModel : ViewModelBase, INavigationAware
    {
        private MagicCardRepository _repository;

        //private ObservableCollection<MagicCard> _magicCards;
        //public ObservableCollection<MagicCard> MagicCards
        //{
        //    get { return _magicCards; }
        //    set { SetProperty(ref _magicCards, value); }
        //}

        private bool _isImporting;
        public bool IsImporting
        {
            get { return _isImporting; }
            set { SetProperty(ref _isImporting, value); }
        }

        public CardsOverviewViewModel(IUnityContainer unityContainer)
            : base(unityContainer)
        {
            _repository = new MagicCardRepository();
        }


        private NotifyTaskCompletion<ObservableCollection<MagicCard>> _loadCardsTask;
        public NotifyTaskCompletion<ObservableCollection<MagicCard>> LoadCardsTask

        {
            get { return _loadCardsTask; }
            set { SetProperty(ref _loadCardsTask, value); }
        }

        private NotifyTaskCompletion<List<string>> _loadLangTask;
        public NotifyTaskCompletion<List<string>> LoadLangTask
        {
            get { return _loadLangTask; }
            set { SetProperty(ref _loadLangTask, value); }
        }

        public bool ShowContent
        {
            get
            {
                if (LoadCardsTask != null)
                {
                    return LoadCardsTask.IsCompleted && !IsImporting;
                }
                return false;
            }
        }

        private DelegateCommand _importCommand;
        private long _filesize;
        private long _position;
        public int ImportProgress
        {
            get
            {
                if (_filesize != 0)
                {
                    return (int)(_position / _filesize);
                }
                else
                {
                    return 0;
                }

            }
        }

        public DelegateCommand ImportCommand =>
            _importCommand ?? (_importCommand = new DelegateCommand(ExecuteImportCommand, () => true));


        async void ExecuteImportCommand()
        {
            OpenFileDialogArguments fileDialogArguments = new OpenFileDialogArguments
            {
                Height = 500,
                Width = 750,
                Filters = "Json Files | *.json",
                SwitchPathPartsAsButtonsEnabled = true,
                CurrentDirectory = $"{Environment.SpecialFolder.DesktopDirectory}",
                ShowHiddenFilesAndDirectories = false,
                ShowSystemFilesAndDirectories = false,
                PathPartsAsButtons = true,
            };
            OpenFileDialogResult fileResults = await OpenFileDialog.ShowDialogAsync(RegionNames.DialogRegion, fileDialogArguments);
            if (fileResults.Confirmed && fileResults.File != null)
            {
                LoadCardsTask = null;
                IsImporting = true;
                RaisePropertyChanged("ShowContent");
                await ImportCards(fileResults.File);
                IsImporting = false;
                RaisePropertyChanged("ShowContent");
                LoadCardsTask = new NotifyTaskCompletion<ObservableCollection<MagicCard>>(Task.Run(() => LoadMagicCards()));
                LoadCardsTask.PropertyChanged += TaskPropertyChanged;
                LoadLangTask = new NotifyTaskCompletion<List<string>>(Task.Run(() => LoadLanguages()));
                RaisePropertyChanged("ShowContent");
            }
        }

        private async Task<List<string>> LoadLanguages()
        {
            return await _repository.GetAllLanguagesAsync();
        }

        private void TaskPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RaisePropertyChanged("ShowContent");
        }

        private async Task ImportCards(string file)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    _filesize = sr.BaseStream.Length;
                    await Task.Run(() =>
                    {
                        while (reader.Read())
                        {
                            if (reader.TokenType == JsonToken.StartObject)
                            {
                                JObject obj = JObject.Load(reader);
                                _repository.SaveNewCard(ParseMagicCards.Parse(obj, _repository));
                            }
                            _position = sr.BaseStream.Position;
                            RaisePropertyChanged("ImportProgress");
                        }
                    });
                }
            }

        }

        private async Task<ObservableCollection<MagicCard>> LoadMagicCards()
        {
            var _result = new ObservableCollection<MagicCard>();
            return (ObservableCollection<MagicCard>)_result.AddRange(await (_repository.GetAllCardsAsync()));
        }

        public override async void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);
            //if (navigationContext.Parameters.Count != 0)
            //{
            //    var filePath = navigationContext.Parameters.GetValue<string>("filePath");
            LoadCardsTask = new NotifyTaskCompletion<ObservableCollection<MagicCard>>(Task.Run(() => LoadMagicCards()));//filePath));
            LoadCardsTask.PropertyChanged += TaskPropertyChanged;
            //}
        }
    }
}
