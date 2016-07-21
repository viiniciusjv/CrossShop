using CrossShop.bl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShop.ViewModel
{
    public class MainViewModel
    {
        ColorPrimaryControl cpControl;
        public  ObservableCollection<ColorsPrimary> Colors
        {
            get; set;
        }
        public MainViewModel() {
            cpControl = new ColorPrimaryControl();
        }
        public void LoadColors() {
            Colors = new ObservableCollection<ColorsPrimary>(cpControl.Get());            
        }

    }
}
