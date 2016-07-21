using CrossShop.bl;
using CrossShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CrossShop
{
    public partial class MenuPage : ContentPage
    {
        public MenuPageViewModel Vm
        {
            get; set;
        }
        public MenuPage()
        {
            InitializeComponent();
            Vm = new MenuPageViewModel();
            lstMenu.ItemsSource = Vm.Menus;
            lstMenu.ItemSelected += LstMenu_ItemSelected;
        }

        private void LstMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Vm.ProcessItemSelected?.Invoke((MyMenuItem)e.SelectedItem);
        }
    }
}
