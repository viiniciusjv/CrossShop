using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using CrossShop.Droid.Services;
using Android.Content.Res;
using Android.Util;
using CrossShop.Droid.Bl;

[assembly: Dependency(typeof(ScreenService))]
namespace CrossShop.Droid.Services
{
    public class ScreenService : ScreenServiceMaster
    {
        public override Xamarin.Forms.Size GetScreenSize()
        {
            return new Xamarin.Forms.Size(PropCloud.ScreenSize.Width, PropCloud.ScreenSize.Height);
        }
    }
}