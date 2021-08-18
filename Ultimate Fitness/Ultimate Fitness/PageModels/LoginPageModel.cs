using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Ultimate_Fitness.PageModels.Base;
using Ultimate_Fitness.Services.Navigation;
using Xamarin.Forms;

namespace Ultimate_Fitness.PageModels
{
    public class LoginPageModel : PageModelBase
    {
        private ICommand _logInCommand;
        private INavigationService _navigationService;

        public ICommand LogInCommand
        {
            get => _logInCommand;
            set => SetProperty(ref _logInCommand, value);
        }

        public LoginPageModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            LogInCommand = new Command(OnLogInAction);
        }

        private void OnLogInAction(object obj)
        {
            _navigationService.NavigateToAsync<HomePageModel>();
        }
    }
}
