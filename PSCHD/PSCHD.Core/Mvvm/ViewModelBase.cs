using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Regions;
using Unity;

namespace PSCHD.Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible, INavigationAware
    {
        protected IEventAggregator _eventAggregator;
        protected IRegionManager _regionManager;
        protected BreadCrumbList _breadCrumbList;
        protected string _name;

        protected ViewModelBase()
        {

        }

        public virtual void Destroy()
        {

        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            try
            {
                //_breadCrumbList.AddToBreadcrumbs(navigationContext.NavigationService.Journal.CurrentEntry.Uri.ToString());
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
