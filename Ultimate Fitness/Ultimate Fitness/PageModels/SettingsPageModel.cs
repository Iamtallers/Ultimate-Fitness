using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Ultimate_Fitness.PageModels.Base;
using Ultimate_Fitness.PageModels.BrowsersPageModel;
using Ultimate_Fitness.Services.Navigation;
using Xamarin.Forms;

namespace Ultimate_Fitness.PageModels
{
    public class SettingsPageModel : PageModelBase
    {
        private ICommand _editprofilecommand;
        private ICommand _changepasswordcommand;
        private ICommand _helpcommand;
        private ICommand _termscommand;
        private ICommand _policycommand;
        private ICommand _faqcommand;

        private INavigationService _navigationService;

        public ICommand EditProfileCommand 
        {
            get => _editprofilecommand;
            set => SetProperty(ref _editprofilecommand, value);
        }
        public ICommand ChangePasswordCommand
        {
            get => _changepasswordcommand;
            set => SetProperty(ref _changepasswordcommand, value);
        }

        public ICommand HelpCommand
        {
            get => _helpcommand;
            set => SetProperty(ref _helpcommand, value);
        }
        public ICommand TermsCommand
        {
            get => _termscommand;
            set => SetProperty(ref _termscommand, value);
        }
        public ICommand PolicyCommand
        {
            get => _policycommand;
            set => SetProperty(ref _policycommand, value);
        }
        public ICommand FAQCommand
        {
            get => _faqcommand;
            set => SetProperty(ref _faqcommand, value);
        }


        public SettingsPageModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            EditProfileCommand = new Command(OnEditProfileAction);
            ChangePasswordCommand = new Command(OnChangePasswordAction);
            HelpCommand = new Command(OnHelpAction);
            TermsCommand = new Command(OnTermsAction);
            PolicyCommand = new Command(OnPolicyAction);
            FAQCommand = new Command(OnFAQAction);
        }

        private async void OnFAQAction(object obj)
        {
            await _navigationService.NavigateToAsync<FAQBrowserModel>();
        }

        private async void OnPolicyAction(object obj)
        {
            await _navigationService.NavigateToAsync<PrivacyPolicyBrowserModel>();
        }

        private async void OnTermsAction(object obj)
        {
            await _navigationService.NavigateToAsync<TermsOfServiceBrowserModel>();
        }

        private async void OnHelpAction(object obj)
        {
            await _navigationService.NavigateToAsync<HelpBrowserModel>();
        }

        private async void OnChangePasswordAction(object obj)
        {
            await _navigationService.NavigateToAsync<HomePageModel>();
        }

        private async void OnEditProfileAction(object obj)
        {
            await _navigationService.NavigateToAsync<LoginPageModel>();
        }
    }
}
