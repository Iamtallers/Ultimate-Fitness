﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultimate_Fitness.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ultimate_Fitness.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageModel();
        }
    }
}
