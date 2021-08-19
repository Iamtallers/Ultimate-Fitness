using System;
using System.Collections.Generic;
using Ultimate_Fitness.PageModels;
using Xamarin.Forms;

namespace Ultimate_Fitness.Pages
{
    public partial class WorkoutsPage : ContentPage
    {
        public WorkoutsPage()
        {
            InitializeComponent();
            BindingContext = new WorkoutsPageModel();
        }
    }
}
