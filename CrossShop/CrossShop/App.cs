using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CrossShop
{
    public class MyApp : Application
    {
        public MyApp()
        {
            // The root page of your application
            MainPage = new MyTestPage();
            Resources = new ResourceDictionary();
            Resources.Add("ForePrimaryColor", Color.Black);
            Resources.Add("BackPrimaryColor", Color.White);


            Style stlDefaultLabelStyle = new Style(typeof(Label));
            stlDefaultLabelStyle.ApplyToDerivedTypes = true;

            Setter StlblDftTextColor = new Setter();

            StlblDftTextColor.Property = Label.TextColorProperty;
            StlblDftTextColor.Value = Application.Current.Resources["ForePrimaryColor"];
            stlDefaultLabelStyle.Setters.Add(StlblDftTextColor);

            Setter StlblDfTextSize = new Setter();
            StlblDfTextSize.Property = Label.FontSizeProperty;
            StlblDfTextSize.Value = 15;
            stlDefaultLabelStyle.Setters.Add(StlblDfTextSize);
           
            Style stlDefaultPageStyle = new Style(typeof(TemplatedPage));
            stlDefaultPageStyle.ApplyToDerivedTypes = true;

            Setter sttDfPageBackColor = new Setter();
            sttDfPageBackColor.Property = TemplatedPage.BackgroundColorProperty;
            sttDfPageBackColor.Value = Color.White;
            stlDefaultPageStyle.Setters.Add(sttDfPageBackColor);

            Resources.Add(stlDefaultPageStyle);
            Resources.Add(stlDefaultLabelStyle);
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
