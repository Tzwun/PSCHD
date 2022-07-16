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

namespace PSCHD.ViewModels
{
    public class CardsOverviewViewModel : ViewModelBase, INavigationAware
    {
        private ObservableCollection<MagicCard> _magicCards;
        private IRegionManager _regionManager;

        public ObservableCollection<MagicCard> MagicCards
        {
            get { return _magicCards; }
            set { SetProperty(ref _magicCards, value); }
        }

        private NotifyTaskCompletion<ObservableCollection<MagicCard>> _loadCardsTask;
        public NotifyTaskCompletion<ObservableCollection<MagicCard>> LoadCardsTask

        {
            get { return _loadCardsTask; }
            set { SetProperty(ref _loadCardsTask, value); }
        }

        public CardsOverviewViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        private async Task<ObservableCollection<MagicCard>> LoadMagicCards()
        {
            var _result = new ObservableCollection<MagicCard>();

            using (StreamReader sr = new StreamReader(@"C:\Users\z004djnf\Downloads\all-cards-20220406091252.json"))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    await Task.Run(() =>
                    {
                        foreach (var item in JsonConvert.DeserializeObject<MagicCards>(sr.ReadToEnd()))
                        {
                            _result.Add(item);
                        }
                    });
                }
            }
            return _result;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            LoadCardsTask = new NotifyTaskCompletion<ObservableCollection<MagicCard>>(LoadMagicCards());
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

    }
}
