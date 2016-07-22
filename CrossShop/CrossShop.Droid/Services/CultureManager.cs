using System;
using Xamarin.Forms;
using System.Threading;
using CrossShop.bl;
using System.Globalization;

[assembly: Dependency(typeof(CrossShop.Droid.Services.CultureManager))]
namespace CrossShop.Droid.Services
{
    public class CultureManager : ICultureManager
    {
        #region ICultureInfo implementation

        public System.Globalization.CultureInfo CurrentCulture
        {
            get
            {
                return Thread.CurrentThread.CurrentCulture;
            }
            set
            {
                CultureInfo.DefaultThreadCurrentCulture = Thread.CurrentThread.CurrentCulture = value;
                
            }
        }

        public System.Globalization.CultureInfo CurrentUICulture
        {
            get
            {
                return Thread.CurrentThread.CurrentUICulture;
            }
            set
            {
                CultureInfo.DefaultThreadCurrentUICulture = Thread.CurrentThread.CurrentUICulture = value;
            }
        }

        #endregion
    }
}