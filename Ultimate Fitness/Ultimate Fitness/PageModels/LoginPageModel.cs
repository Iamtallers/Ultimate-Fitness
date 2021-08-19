using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Ultimate_Fitness.PageModels.Base;
using Ultimate_Fitness.Services.Account;
using Ultimate_Fitness.Services.Navigation;
using Xamarin.Forms;

namespace Ultimate_Fitness.PageModels
{
    public class LoginPageModel : PageModelBase
    {
        private ICommand _logInCommand;
        private INavigationService _navigationService;
        private IAccountService _accountService;

        public ICommand LogInCommand
        {
            get => _logInCommand;
            set => SetProperty(ref _logInCommand, value);
        }

        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public LoginPageModel(INavigationService navigationService, IAccountService accountService)
        {
            _navigationService = navigationService;
            _accountService = accountService;

            LogInCommand = new Command(OnLogInAction);
        }

        private async void OnLogInAction(object obj)
        {
            var loginAttempt = await _accountService.LoginAsync(Username, Password);
            if (loginAttempt)
            {
                await _navigationService.NavigateToAsync<SettingsPageModel>();
            }
            else
            {
                // Display Alert for faliure
            }

        }
    }
}
