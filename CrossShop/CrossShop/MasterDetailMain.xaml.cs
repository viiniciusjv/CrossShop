using CrossShop.bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CrossShop
{
    public partial class MasterDetailMain : MasterDetailPage
    {
        public MasterDetailMain()
        {
            InitializeComponent();
            ((MenuPage)masterPage).Vm.ProcessItemSelected = new Action<MyMenuItem>(NavigateTo);
        }
        void NavigateTo(MyMenuItem menu)
        {
            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);
            Detail = new NavigationPage(displayPage);
            IsPresented = false;
        }
    }
}
