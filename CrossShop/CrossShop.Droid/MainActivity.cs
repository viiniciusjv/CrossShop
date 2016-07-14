using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;
using CrossShop.Droid.Bl;


namespace CrossShop.Droid
{
    [Activity(Label = "CrossShop", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {            
            
            base.OnCreate(bundle);            
            global::Xamarin.Forms.Forms.Init(this, bundle);
            DisplayMetrics dm = new DisplayMetrics();
            WindowManager.DefaultDisplay.GetMetrics(dm);
            PropCloud.ScreenSize = new Xamarin.Forms.Size(dm.WidthPixels, dm.HeightPixels);
            LoadApplication(new MyApp ());
           

        }
    }
}

    