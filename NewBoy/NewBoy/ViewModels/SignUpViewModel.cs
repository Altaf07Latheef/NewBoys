using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewBoy.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {
        INavigationService _navigationService;
        public SignUpViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

        }
        private string _signupEmail;
        public string SignupEmail
        {
            get { return _signupEmail; }
            set
            {
                SetProperty(ref _signupEmail, value);
                RaisePropertyChanged();
            }
        }
        private string _signupPassword;
        public string SignupPassword
        {
            get { return _signupPassword; }
            set
            {
                SetProperty(ref _signupPassword, value);
                RaisePropertyChanged();
            }
        }
        //private DelegateCommand signUpButtonAction { get; set; }
        //public DelegateCommand SignUpButtonAction
        //{
        //    get
        //    {
        //        signUpButtonAction = signUpButtonAction ?? new DelegateCommand(() => GetSignupResponse());
        //        return signUpButtonAction;
        //    }
        //}
    }
}
