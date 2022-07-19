using CommonServiceLocator;
using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Unity;
using PSCHD.Core.Mvvm;
using PSCHD.Modules.ModuleName;
using PSCHD.Resources;
using PSCHD.Services;
using PSCHD.Services.Interfaces;
using PSCHD.ViewModels;
using PSCHD.Views;
using System;
using System.Globalization;
using System.Reflection;
using System.Windows;

namespace PSCHD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                var viewName = viewType.FullName;
                viewName = viewName.Replace(".Views.", ".ViewModels.");
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                //var folder = ".ViewModels.";
                var suffix = "ViewModel";  //  viewName.EndsWith("View") ? "Model" : "ViewModel";
                var viewModelName = string.Format(CultureInfo.InvariantCulture, "{0}{1}, {2}", viewName, suffix, viewAssemblyName);
                return Type.GetType(viewModelName);
            });

            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
            containerRegistry.RegisterForNavigation<SettingsView, SettingsViewViewModel>(typeof(SettingsView).FullName);
            containerRegistry.RegisterForNavigation<ThemeSettings, ThemeSettingsViewModel>(typeof(ThemeSettings).FullName);
            containerRegistry.RegisterForNavigation<CardsOverview, CardsOverviewViewModel>(typeof(CardsOverview).FullName);
            containerRegistry.RegisterForNavigation<UserView, UserViewViewModel>(typeof(UserView).FullName);
            containerRegistry.RegisterForNavigation<UserCollectionsView, UserCollectionsViewViewModel>(typeof(UserCollectionsView).FullName);
            containerRegistry.RegisterForNavigation<StonksView, StonksViewViewModel>(typeof(StonksView).FullName);
            containerRegistry.RegisterDialog<LoginView, LoginViewModel>(typeof(LoginView).FullName);
        }

        protected override void RegisterRequiredTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterRequiredTypes(containerRegistry);
            containerRegistry.RegisterInstance(new BreadCrumbList(Container.Resolve<IRegionManager>(), Container.Resolve<IEventAggregator>()));
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
        }
    }
}
