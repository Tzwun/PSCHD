using Prism.Commands;
using Prism.Mvvm;

namespace PSCHD.ViewModels
{
    public class MenuItem : BindableBase
    {
        public MenuItem()
        {

        }
        private DelegateCommand _navigate;
        public DelegateCommand Navigate
        {
            get { return _navigate; }
            set { SetProperty(ref _navigate, value); }
        }

        private string _displayName;
        public string DisplayName
        {
            get { return _displayName; }
            set { SetProperty(ref _displayName, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private object _content;
        public object Content
        {
            get { return _content; }
            set { SetProperty(ref _content, value); }
        }
        private string _icon;
        public string Icon
        {
            get { return _icon; }
            set { SetProperty(ref _icon, value); }
        }
    }
}
