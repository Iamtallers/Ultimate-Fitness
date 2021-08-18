using System;
using System.Threading.Tasks;
using Ultimate_Fitness.PageModels;
using Ultimate_Fitness.PageModels.Base;
using Ultimate_Fitness.Services.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ultimate_Fitness
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();                        
        }

        Task InitNavigation()
        {
            var navService = PageModelLocator.Resolve<INavigationService>();
            return navService.NavigateToAsync<LoginPageModel>();
        }

        protected override async void OnStart()
        {
            await InitNavigation();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
