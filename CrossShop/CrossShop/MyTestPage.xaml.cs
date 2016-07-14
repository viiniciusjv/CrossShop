using CrossShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CrossShop
{
    public partial class MyTestPage : ContentPage
    {
        MainViewModel _vm;
        
        public MyTestPage()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            _vm.LoadColors();
            lstProds.ItemsSource = MainViewModel.Colors;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}
