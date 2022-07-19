using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace PSCHD.Core.Mvvm
{
    public class BreadCrumbList : BindableBase
    {
        private IRegionManager _regionManager;
        private IEventAggregator _eventAggregator;
        private ObservableCollection<BreadCrumb> _breadCrumbs;
        public ObservableCollection<BreadCrumb> BreadCrumbs
        {
            get { return _breadCrumbs; }
            set { SetProperty(ref _breadCrumbs, value); }
        }

        public BreadCrumbList(IRegionManager RegionManager, IEventAggregator Eventaggregator)
        {
            _regionManager = RegionManager;
            _eventAggregator = Eventaggregator;
            BreadCrumbs = new ObservableCollection<BreadCrumb>();
        }

        private void NavigateTo(string obj)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, obj);
        }

        private void NavigateToMachine(string obj, string parameter)
        {
            var temp = new NavigationParameters();
            temp.Add("param", parameter);
            obj = Regex.Replace(obj, @"[V]\d|[B]\d|\d{2}", string.Empty);
            _regionManager.RequestNavigate(RegionNames.ContentRegion, obj, temp);
        }

        public void AddToBreadcrumbs(string obj)
        {
            if (!BreadCrumbs.Any(b => b.ViewModelName == obj))//(!BreadCrumbs.ContainsKey(obj))
            {
                BreadCrumbs.Add(new BreadCrumb(obj, new DelegateCommand<string>((o) =>
                {
                    ClearAllClearable();
                    NavigateTo(obj);
                })));
                RaisePropertyChanged("BreadCrumbs");
            }
        }

        public void AddToBreadcrumbsMachine(string obj, string parameter)
        {
            if (!BreadCrumbs.Any(b => b.ViewModelName == obj))//(!BreadCrumbs.ContainsKey(obj))
            {
                BreadCrumbs.Add(new BreadCrumb(obj, new DelegateCommand<string>((o) =>
                {
                    NavigateToMachine(obj, parameter);
                    BreadCrumbs.Remove(BreadCrumbs.SingleOrDefault(b => b.ViewModelName == obj));

                }), showsBadge: true, badge: parameter));
            }
            RaisePropertyChanged("BreadCrumbs");
        }

        public void AddToBreadcrumbsChat(string obj, string parameter, Action AdditionalButtonAction, Action AdditionalCloseAction)
        {
            if (!BreadCrumbs.Any(b => b.ViewModelName == obj))
            {
                BreadCrumbs.Insert(0, new BreadCrumb(
                    obj, new DelegateCommand<string>((o) =>
                    {
                        var temp = new NavigationParameters();
                        temp.Add("param", parameter);
                        _regionManager.RequestNavigate(RegionNames.ContentRegion, obj, temp);
                        AdditionalButtonAction();
                        //NavigateToMachine(obj, parameter);
                    }),
                    badge: parameter,
                    showChevron: false,
                    canbeCleared: false,
                    showsBadge: true,
                    showsCloseCommand: true,
                    closeCommand: new DelegateCommand<string>((o) =>
                    {
                        DeleteBreadcrumbs(obj);
                        AdditionalCloseAction();
                    }
                    )));
            }

            RaisePropertyChanged("BreadCrumbs");
        }

        public void DeleteBreadcrumbs(string obj)
        {
            if (BreadCrumbs.Any(b => b.ViewModelName == obj))
            {
                BreadCrumbs.Remove(BreadCrumbs.SingleOrDefault(b => b.ViewModelName == obj));
            }
        }

        public void ClearAllClearable()
        {

            for (int i = 0; i < BreadCrumbs.Count; i++)
            {
                if (BreadCrumbs[i].CanBeCleared)
                {
                    DeleteBreadcrumbs(BreadCrumbs[i].ViewModelName);
                }
            }
        }
    }
}
