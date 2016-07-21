using CrossShop.bl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossShop.ViewModel
{
    public class MenuPageViewModel
    {
        public Action<MyMenuItem> ProcessItemSelected
        {
            get; set;
        }
        public ObservableCollection<MyMenuItem> Menus
        {
            get; set;
        }
        public MenuPageViewModel()
        {
            Menus = new ObservableCollection<MyMenuItem>();
            Menus.Add(new MyMenuItem() { Name = "Acompanhar pedidos", TargetType = typeof(MyMainPage) });
            Menus.Add(new MyMenuItem() { Name = "Ofertas", TargetType = typeof(ImagePage) });
            Menus.Add(new MyMenuItem() { Name = "Minha conta", TargetType = typeof(MyMainPage) });
            Menus.Add(new MyMenuItem() { Name = "Fale conosco", TargetType = typeof(ImagePage) });
        }
    }
}
