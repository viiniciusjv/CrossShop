using CrossShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CrossShop
{
    public partial class MyMainPage : ContentPage
    {
        MainViewModel _vm;
        public MyMainPage()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            _vm.LoadColors();
            lstProds.ItemsSource = _vm.Colors;                
        }
    }
}
