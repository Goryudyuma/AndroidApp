using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;


namespace App1
{
    public class App : Application
    {
        public App()
        {
            MainPage = new MapPage();

            // The root page of your application

            /*
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Start,
                    Children = {
                        new Label {
                            //VerticalTextAlignment = TextAlignment.Start,
                            //Text = (1+2).ToString(),
                            HorizontalTextAlignment = TextAlignment.Start,
                            Text = (1+2).ToString()
                        }
                    }
                }
            };
            */
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

    public class MapPage : ContentPage
    {
        public MapPage()
        {
            var map = new Map(
                MapSpan.FromCenterAndRadius(
                    new Position(35.71, 139.81),
                    Distance.FromMiles(0.2)))
            {
                IsShowingUser = true,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            Content = new StackLayout
            {
                Children = { map }
            };
        }
    }
}
