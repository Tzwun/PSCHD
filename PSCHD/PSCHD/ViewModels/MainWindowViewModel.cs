using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PSCHD.Core;
using PSCHD.Views;

namespace PSCHD.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        private DelegateCommand _settings_Command;
        public DelegateCommand Settings_Command =>
            _settings_Command ?? (_settings_Command = new DelegateCommand(ExecuteSettings_Command, () => true));

        private void ExecuteSettings_Command()
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, typeof(SettingsView).FullName);
        }

        private DelegateCommand _exitApplication_Command;
        public DelegateCommand ExitApplication_Command =>
            _exitApplication_Command ?? (_exitApplication_Command = new DelegateCommand(ExecuteExitApplication_Command, () => true));

        private void ExecuteExitApplication_Command()
        {
            App.Current.Shutdown();
        }

        private DelegateCommand _loadCards;
        public DelegateCommand LoadCards_Command =>
            _loadCards ?? (_loadCards = new DelegateCommand(ExecuteLoadCards_Command, () => true));

        void ExecuteLoadCards_Command()
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, typeof(CardsOverview).FullName);
        }


        private string _title = "PSHD";
        private IRegionManager _regionManager;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionmanager)
        {
            _regionManager = regionmanager;
        }
    }
}
