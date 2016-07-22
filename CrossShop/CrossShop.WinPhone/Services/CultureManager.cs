using System;
using Xamarin.Forms;
using System.Threading;
using CrossShop.bl;
using System.Globalization;

[assembly: Dependency(typeof(CrossShop.WinPhone.Services.CultureManager))]
namespace CrossShop.WinPhone.Services
{
    public class CultureManager : ICultureManager
    {
        #region ICultureInfo implementation

        public System.Globalization.CultureInfo CurrentCulture
        {
            get
            {                      
                return CultureInfo.DefaultThreadCurrentCulture;
            }
            set
            {
                CultureInfo.DefaultThreadCurrentCulture = value;
            }
        }

        public System.Globalization.CultureInfo CurrentUICulture
        {
            get
            {                
                return CultureInfo.DefaultThreadCurrentUICulture;
            }
            set
            {
                CultureInfo.DefaultThreadCurrentUICulture = value;
            }
        }

        #endregion
    }
}