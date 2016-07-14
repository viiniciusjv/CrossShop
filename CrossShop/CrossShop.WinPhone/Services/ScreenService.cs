using CrossShop.WinPhone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(ScreenService))]
namespace CrossShop.WinPhone.Services
{
    public class ScreenService : ScreenServiceMaster
    {
        public override Size GetScreenSize()
        {
            return new Size(Windows.UI.Xaml.Window.Current.Bounds.Width, Windows.UI.Xaml.Window.Current.Bounds.Height);
        }

     
    }
}
