using System;
using System.Collections.Generic;
using System.Text;
using TinyIoC;
using Ultimate_Fitness.Pages;
using Ultimate_Fitness.Services.Navigation;
using Xamarin.Forms;

namespace Ultimate_Fitness.PageModels.Base
{
    public class PageModelLocator
    {
        static TinyIoCContainer _container;
        static Dictionary<Type, Type> _viewLookup;

        static PageModelLocator()
        {
            _container = new TinyIoCContainer();
            _viewLookup = new Dictionary<Type, Type>();

            //Register pages and pagemodels
            Register<LoginPageModel, LoginPage>();
            Register<HomePageModel, HomePage>();
            Register<SettingsPageModel, SettingsPage>();
            Register<ProfilePageModel, ProfilePage>();


            //Register services (Services are registered as SIngletons by defualt)
            _container.Register<INavigationService, NavigationService>();
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }

        public static Page CreatePageFor(Type pageModelType)
        {
            var pageType = _viewLookup[pageModelType];
            var page = (Page)Activator.CreateInstance(pageType);
            var pageModel = _container.Resolve(pageModelType);
            page.BindingContext = pageModel;
            return page;
        }

        static void Register<TPageModel, TPage>() where TPageModel : PageModelBase where TPage : Page
        {
            _viewLookup.Add(typeof(TPageModel), typeof(TPage));
            _container.Register<TPageModel>();
        }
    }
}
 