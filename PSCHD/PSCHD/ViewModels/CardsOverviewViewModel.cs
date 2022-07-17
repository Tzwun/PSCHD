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

namespace PSCHD.ViewModels
{
    public class CardsOverviewViewModel : ViewModelBase, INavigationAware
    {
        private MagicCardRepository _repository;

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
            _repository = new MagicCardRepository();
            var _result = new ObservableCollection<MagicCard>();

            using (StreamReader sr = new StreamReader(@"C:\Users\z004djnf\Downloads\all-cards-20220406091252_All.json"))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    await Task.Run(() =>
                    {
                        while (reader.Read())
                        {
                            if (reader.TokenType == JsonToken.StartObject)
                            {
                                JObject obj = JObject.Load(reader);
                                _repository.SaveNewCard(ParseMagicCards.Parse(JsonConvert.DeserializeObject<RawMagicCard>(obj.ToString())));
                            }
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
