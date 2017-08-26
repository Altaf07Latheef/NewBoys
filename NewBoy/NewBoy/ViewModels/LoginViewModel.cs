using NewBoy.Models;
using NewBoy.Service;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBoy.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        INavigationService _navigationService;
        public Parameter param = new Parameter();
        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            param.ptype = "Login";
        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value);
                RaisePropertyChanged();
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value);
                RaisePropertyChanged();
            }
        }
        private DelegateCommand loginButtonAction { get; set; }
        public DelegateCommand LoginButtonAction
        {
            get {
                loginButtonAction = loginButtonAction ?? new DelegateCommand(() =>GetLoginResponse());
                return loginButtonAction;
            }
        }

        private async Task GetLoginResponse()
        {
            var remoteResult = new RemoteService();
            var result = await remoteResult.GetRemoteService(param);
            
        }
    }
}
