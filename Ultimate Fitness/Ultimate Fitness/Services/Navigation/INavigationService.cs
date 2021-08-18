﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Fitness.Services.Navigation
{
    public interface INavigationService
    {
        /// <summary>
        /// NNavigation Method to push on to navigation stack
        /// </summary>
        /// <typeparam name="TPageModelBase"></typeparam>
        /// <param name="navigationData"></param>
        /// <param name="setRoot"></param>
        /// <returns></returns>
        Task NavigateToAsync<TPageModelBase>(object navigationData = null, bool setRoot = false);
        /// <summary>
        /// To pop off of navigation stack
        /// </summary>
        /// <returns></returns>
        Task GoBackAsync();
    }
}
