using CommonServiceLocator;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Regions;
using Prism.Services.Dialogs;
using Unity;
using Unity.Resolution;

namespace PSCHD.Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible, INavigationAware
    {
        protected IUnityContainer UnityContainer;
        protected IEventAggregator _eventAggregator;
        protected IRegionManager _regionManager;
        protected BreadCrumbList _breadCrumbList;
        protected IDialogService _dialogService;
        protected string _name;

        protected ViewModelBase(IUnityContainer unityContainer)
        {
            UnityContainer = unityContainer;
            _breadCrumbList = UnityContainer.Resolve<BreadCrumbList>();
            _regionManager = UnityContainer.Resolve<IRegionManager>();
            _eventAggregator = UnityContainer.Resolve<IEventAggregator>();
        }

        public virtual void Destroy()
        {

        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            try
            {
                _breadCrumbList.AddToBreadcrumbs(navigationContext.NavigationService.Journal.CurrentEntry.Uri.ToString());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
