using PSCHD.Core.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace PSCHD.ViewModels
{
    public class UserViewViewModel : ViewModelBase
    {
        public UserViewViewModel(IUnityContainer unityContainer)
            : base(unityContainer)
        {

        }
    }
}
