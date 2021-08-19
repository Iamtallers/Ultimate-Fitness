using System;
using System.Collections.ObjectModel;
using Ultimate_Fitness.Models;
using Ultimate_Fitness.PageModels.Base;

namespace Ultimate_Fitness.PageModels
{
    public class WorkoutsPageModel : PageModelBase
    {
        public ObservableCollection<GymWorkoutsCategoryModel> GymWorkoutsCategoryList { get; set; }
        public ObservableCollection<HomeWorkoutsCategoryModel> HomeWorkoutsCategoryList { get; set; }


        public WorkoutsPageModel()
        {
            GymWorkoutsCategoryList = new ObservableCollection<GymWorkoutsCategoryModel>();
            HomeWorkoutsCategoryList = new ObservableCollection<HomeWorkoutsCategoryModel>();


            GymWorkoutsCategoryList.Add(new GymWorkoutsCategoryModel
            {
                gCategory = "Legs",
                gImage = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/best-leg-exercises-for-women-1595274323.jpg"
            });
            GymWorkoutsCategoryList.Add(new GymWorkoutsCategoryModel
            {
                gCategory = "Chest",
                gImage = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/athlete-working-out-at-gym-royalty-free-image-1595874529.jpg"
            });
            GymWorkoutsCategoryList.Add(new GymWorkoutsCategoryModel
            {
                gCategory = "Back",
                gImage = "https://www.mensjournal.com/wp-content/uploads/mf/muscular-back-1280.jpg"
            });
            GymWorkoutsCategoryList.Add(new GymWorkoutsCategoryModel
            {
                gCategory = "Tricep",
                gImage = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/triceps-exercises-1559573786.png"
            });

            HomeWorkoutsCategoryList.Add(new HomeWorkoutsCategoryModel
            {
                hCategory = "Back & Bicep",
                hImage = "https://www.mensjournal.com/wp-content/uploads/mf/muscular-back-1280.jpg"
            });
            HomeWorkoutsCategoryList.Add(new HomeWorkoutsCategoryModel
            {
                hCategory = "Legs",
                hImage = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/best-leg-exercises-for-women-1595274323.jpg"
            });
            HomeWorkoutsCategoryList.Add(new HomeWorkoutsCategoryModel
            {
                hCategory = "Chest",
                hImage = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/athlete-working-out-at-gym-royalty-free-image-1595874529.jpg"
            });
            HomeWorkoutsCategoryList.Add(new HomeWorkoutsCategoryModel
            {
                hCategory = "Shoulder",
                hImage = "https://hips.hearstapps.com/vidthumb/brightcove/578940c0e694aa370d8835b3/thumb_1468612802.png"
            });
            HomeWorkoutsCategoryList.Add(new HomeWorkoutsCategoryModel
            {
                hCategory = "Tricep",
                hImage = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/triceps-exercises-1559573786.png"
            });
            HomeWorkoutsCategoryList.Add(new HomeWorkoutsCategoryModel
            {
                hCategory = "Hamstring",
                hImage = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/triceps-exercises-1559573786.png"
            });
            HomeWorkoutsCategoryList.Add(new HomeWorkoutsCategoryModel
            {
                hCategory = "Bicep",
                hImage = "https://www.mensjournal.com/wp-content/uploads/mf/muscular-back-1280.jpg"
            });
            HomeWorkoutsCategoryList.Add(new HomeWorkoutsCategoryModel
            {
                hCategory = "Abs",
                hImage = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/athlete-working-out-at-gym-royalty-free-image-1595874529.jpg"
            });
            HomeWorkoutsCategoryList.Add(new HomeWorkoutsCategoryModel
            {
                hCategory = "HIIT",
                hImage = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/best-leg-exercises-for-women-1595274323.jpg"
            });












        }
    }
}
