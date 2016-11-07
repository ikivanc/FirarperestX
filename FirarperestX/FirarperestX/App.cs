using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FirarperestX
{
    public class App : Application
    {

        public Photoset selectedPhotoset;

        public App()
        {
            // The root page of your application
            //MainPage = new Views.Home();            
            MainPage = new MainPageMaster();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
