using Prism.Commands;

namespace PSCHD.Core.Mvvm
{
    public class BreadCrumb
    {
        private string _viewModelName;
        private DelegateCommand<string> _buttonCommand;
        private bool _showsBadge;
        private bool _canBeCleared;
        private bool _showsCloseCommand;
        private DelegateCommand<string> _closeCommand;
        private string _badge;
        private bool _showChevron;

        public string ViewModelName
        {
            get { return _viewModelName; }
            set { _viewModelName = value; }
        }

        public DelegateCommand<string> ButtonCommand
        {
            get { return _buttonCommand; }
            set { _buttonCommand = value; }
        }

        public bool CanBeCleared
        {
            get { return _canBeCleared; }
            set { _canBeCleared = value; }
        }

        public string Badge
        {
            get { return _badge; }
            set { _badge = value; }
        }

        public bool ShowsBadge
        {
            get { return _showsBadge; }
            set { _showsBadge = value; }
        }

        public bool ShowsCloseCommand
        {
            get { return _showsCloseCommand; }
            set { _showsCloseCommand = value; }
        }

        public DelegateCommand<string> CloseCommand
        {
            get { return _closeCommand; }
            set { _closeCommand = value; }
        }

        public bool ShowChevron
        {
            get { return _showChevron; }
            set { _showChevron = value; }
        }

        public BreadCrumb(string viewModelName, DelegateCommand<string> buttonCommand, string badge = null, bool showChevron = true, bool canbeCleared = true, bool showsBadge = false, bool showsCloseCommand = false, DelegateCommand<string> closeCommand = null)
        {
            _viewModelName = viewModelName;
            _buttonCommand = buttonCommand;
            _badge = badge;
            _showChevron = showChevron;
            _canBeCleared = canbeCleared;
            _showsBadge = showsBadge;
            _showsCloseCommand = showsCloseCommand;
            _closeCommand = closeCommand;

        }
    }
}