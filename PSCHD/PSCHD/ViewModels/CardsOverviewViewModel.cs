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
using System.Windows;
using System.Threading;

namespace PSCHD.ViewModels
{
    public class CardsOverviewViewModel : ViewModelBase, INavigationAware
    {
        private MagicCardRepository _repository;
        private Dispatcher _dispatcher;
        private int _importedCards;
        public int ImportedCards
        {
            get { return _importedCards; }
            set { SetProperty(ref _importedCards, value); }
        }

        private bool _isImporting;
        public bool IsImporting
        {
            get { return _isImporting; }
            set { SetProperty(ref _isImporting, value); }
        }

        private int _objectsInQueue;
        public int ObjectsInQueue
        {
            get { return _objectsInQueue; }
            set { SetProperty(ref _objectsInQueue, value); }
        }

        public CardsOverviewViewModel(IUnityContainer unityContainer)
            : base(unityContainer)
        {
            _repository = new MagicCardRepository(-1);
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
        public float ImportProgress
        {
            get
            {
                if (_filesize != 0)
                {
                    return (_position / _filesize);
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
                ImportedCards = 0;
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
                    Queue<JObject> jObjects = new Queue<JObject>();
                    List<MagicCard> cards = new List<MagicCard>();
                    List<string> CardIDs = new List<string>();
                    object locker = new object();
                    object doclocker = new object();
                    object jsonLocker = new object();
                    bool DocIsFinished = false;
                    using (var _reps = new MagicCardRepository(-1))
                    {
                        CardIDs = _reps.getAllInsertedIDs();
                    }

                    var tasks = new List<Task>();
                    while (!DocIsFinished)
                    {
                        for (var i = 0; i < Environment.ProcessorCount; i++)
                        {
                            if (i == 0)
                            {
                                tasks.Add(Task.Run(() =>
                                {
                                    JObject tempObject = null;
                                    lock (jsonLocker)
                                    {
                                        while (reader.Read())
                                        {
                                            if (reader.TokenType == JsonToken.StartObject)
                                            {
                                                if ((jObjects.Count > 2000))
                                                {
                                                    Task.Delay(600).Wait();
                                                }
                                                //if ((jObjects.Count > 500))
                                                //{
                                                //    Task.Delay(15).Wait();
                                                //}
                                                tempObject = JObject.Load(reader);
                                                if (!CardIDs.Contains(tempObject.Value<string>("id")) && tempObject.Value<string>("object") == "card")
                                                {
                                                    CardIDs.Add(tempObject.Value<string>("id"));
                                                    if (tempObject != null)
                                                    {
                                                        lock (locker)
                                                        {
                                                            jObjects.Enqueue(tempObject);
                                                        }
                                                    }
                                                }
                                            }
                                            //_dispatcher.BeginInvoke(() => ImportedCards++);
                                            _dispatcher.BeginInvoke(() => RaisePropertyChanged("ImportProgress"));
                                            _dispatcher.BeginInvoke(() => ObjectsInQueue = jObjects.Count);

                                            _position = sr.BaseStream.Position;
                                            if (_position >= _filesize)
                                            {
                                                lock (doclocker)
                                                {
                                                    DocIsFinished = true;
                                                }
                                            }
                                        }
                                        RaisePropertyChanged("ImportProgress");
                                    }
                                }
                            ));
                            }
                            else
                            {
                                tasks.Add(Task.Run(() =>
                                {
                                    int id = i;
                                    int lastRefresh = 0;
                                    JObject obj = null;
                                    while (!DocIsFinished)
                                    {
                                        if (jObjects.Count > 0)
                                        {
                                            lock (locker)
                                            {
                                                if (jObjects.Count != 0)
                                                {
                                                    obj = jObjects.Dequeue();
                                                }
                                            }
                                            //if ((ImportedCards - lastRefresh) >= 2000)
                                            //{
                                            //    //_repositories[i].DisposeAndCreate();
                                            //    //repo.DisposeAndCreate();
                                            //    lastRefresh = ImportedCards;
                                            //}
                                            if (obj != null)
                                            {
                                                //_repositories[i].SaveNewCard(ParseMagicCards.Parse(obj, _repositories[i]));
                                                var repo = new MagicCardRepository(id, Thread.CurrentThread);
                                                if (repo.SaveNewCard(ParseMagicCards.Parse(obj, repo)))
                                                    _dispatcher.BeginInvoke(() => ImportedCards++);
                                                repo.Dispose();
                                                _dispatcher.BeginInvoke(() => ObjectsInQueue = jObjects.Count);
                                            }
                                        }
                                    }
                                }));
                            }
                        }
                        await Task.WhenAll(tasks);
                    }
                }
            }
        }


        private async Task<ObservableCollection<MagicCard>> LoadMagicCards()
        {
            var _result = new ObservableCollection<MagicCard>();
            return (ObservableCollection<MagicCard>)_result.AddRange(await (_repository.GetAllCardsAsync()));
        }

        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;

        }

        public override async void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);
            _dispatcher = Application.Current.Dispatcher;
            //if (navigationContext.Parameters.Count != 0)
            //{
            //    var filePath = navigationContext.Parameters.GetValue<string>("filePath");
            LoadCardsTask = new NotifyTaskCompletion<ObservableCollection<MagicCard>>(Task.Run(() => LoadMagicCards()));//filePath));
            LoadCardsTask.PropertyChanged += TaskPropertyChanged;
            //}
        }
    }
}
