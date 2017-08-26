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
        private string _loginEmail;
        public string LoginEmail
        {
            get { return _loginEmail; }
            set { SetProperty(ref _loginEmail, value);
                RaisePropertyChanged();
            }
        }
        private string _loginPassword;
        public string LoginPassword
        {
            get { return _loginPassword; }
            set { SetProperty(ref _loginPassword, value);
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
        private DelegateCommand signupClickAction { get; set; }
        public DelegateCommand SignupClickAction
        {
            get { return signupClickAction = signupClickAction ?? new DelegateCommand(() => {
                _navigationService.NavigateAsync("SignUp");
            }); }
        }

        private async Task GetLoginResponse()
        {
            var remoteResult = new RemoteService();
           // var result = await remoteResult.GetRemoteService(param);
            
        }
    }
}
