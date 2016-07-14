using CrossShop.iOS.Services;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
[assembly: Dependency(typeof(ScreenService))]
namespace CrossShop.iOS.Services
{
    public class ScreenService : ScreenServiceMaster
    {
        public override Size GetScreenSize()
        {
            return new Size((double)UIScreen.MainScreen.Bounds.Width, (double)UIScreen.MainScreen.Bounds.Height);
        }
    }
}
