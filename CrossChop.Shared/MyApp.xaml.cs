using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace CrossShop.Shared
{
    public partial class MyApp : Application
    {
        #region Properties    

        public new static MyApp Current
        {
            get
            {
                return (MyApp)Application.Current;
            }
        }

        #endregion

        public MyApp()
        {


            InitializeComponent();
        }

        protected override void OnSleep()
        {

            base.OnSleep();
        }

        protected override void OnStart()
        {

            base.OnStart();
        }
    }
}