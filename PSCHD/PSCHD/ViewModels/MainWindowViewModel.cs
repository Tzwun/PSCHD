using MaterialDesignExtensions.Controls;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PSCHD.Core;
using PSCHD.Core.Mvvm;
using PSCHD.Helper;
using PSCHD.Views;
using System;
using System.Windows.Threading;
using Unity;

namespace PSCHD.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public BreadCrumbList BreadCrumbList
        {
            get { return _breadCrumbList; }
            set { SetProperty(ref _breadCrumbList, value); }
        }

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

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand, () => true));


        private DelegateCommand<string> _viewChangeCommand;
        public DelegateCommand<string> ViewChangeCommand =>
            _viewChangeCommand ?? (_viewChangeCommand = new DelegateCommand<string>(ExecuteViewChangeCommand, (s) => true));

        private int _selectedMenu;
        public int SelectedMenu
        {
            get { return _selectedMenu; }
            set { SetProperty(ref _selectedMenu, value); }
        }

        void ExecuteViewChangeCommand(string obj)
        {
            if (obj != null)
            {
                if (true)//_loggedUser.ActivatedUser != null)
                {
                    if (true)//AuthContextSelector(GetAuthContextFromMenuName(obj)))
                    {
                        _breadCrumbList.ClearAll();
                        RaisePropertyChanged("BreadCrumbList");
                        _regionManager.RequestNavigate(RegionNames.ContentRegion, MainRegionNavigate.To(obj));
                        if (obj == "Background")
                        {
                            _breadCrumbList.ClearAll();
                            SelectedMenu = -1;
                        }
                    }
                    else
                    {
                        string ViewIdentification = obj;
                        //string ViewName = LocalizationProvider.GetLocalizedValue<string>(GetAuthContextFromMenuName(obj));
                        //ExclamationMessageBoxEnqueue(string.Format(LocalizationProvider.GetLocalizedValue<string>("Permission_Denied"), ViewName));
                        SelectedMenu = -1;
                    }
                }
                else
                {
                    if (obj == "Background")
                    {
                        //_regionManager.RequestNavigate(RegionNames.ContentRegion, MainRegionNavigate.To(obj));
                        SelectedMenu = -1;
                        _breadCrumbList.ClearAll();
                    }
                    else
                    {
                        string ViewIdentification = obj;
                        //string ViewName = LocalizationProvider.GetLocalizedValue<string>(GetAuthContextFromMenuName(obj));
                        //ExclamationMessageBoxEnqueue(string.Format(LocalizationProvider.GetLocalizedValue<string>("Permission_Denied"), ViewName));
                        SelectedMenu = -1;
                    }
                }
            }
            else
            {
                _breadCrumbList.ClearAll();
            }
        }

        public DateTime Uhrzeit
        {
            get { return DateTime.Now; }
        }

        async void ExecuteLoginCommand()
        {

        }

        public MainWindowViewModel(IUnityContainer unityContainer)
            : base(unityContainer)
        {
            //Time Initialization
            _timer = new DispatcherTimer();
            _timer.Tick += UpdateTime;
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            _timer.Start();
        }

        private void UpdateTime(object sender, EventArgs e)
        {
            RaisePropertyChanged("Uhrzeit");
        }

        private string _title = "PSCHD";
        private DispatcherTimer _timer;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
