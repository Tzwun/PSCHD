using Prism.Commands;
using Prism.Services.Dialogs;
using PSCHD.Core.Mvvm;
using PSCHD.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSCHD.ViewModels
{
    internal class LoginViewModel : ViewModelBase, IDialogAware
    {
        private string _userName;
        private LoginView _view;

        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        public LoginView View
        {
            get { return _view; }
            set { SetProperty(ref _view, value); }
        }

        private DelegateCommand _okCommand;
        public DelegateCommand OkCommand =>
            _okCommand ?? (_okCommand = new DelegateCommand(ExecuteOkCommand, CanExecuteOkCommand));

        void ExecuteOkCommand()
        {

        }

        bool CanExecuteOkCommand()
        {
            return true;
        }

        private DelegateCommand _cancelCommand;
        public DelegateCommand CancelCommand =>
            _cancelCommand ?? (_cancelCommand = new DelegateCommand(ExecuteCancelCommand, () => true));

        void ExecuteCancelCommand()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.Cancel));
        }

        public string Title => "";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {

        }
    }
}
