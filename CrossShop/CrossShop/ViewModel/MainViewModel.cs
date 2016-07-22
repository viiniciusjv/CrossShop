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
        OfertasControl ofControl;
        public ObservableCollection<ColorsPrimary> Colors
        {
            get; set;
        }

        public ObservableCollection<Oferta> Ofertas
        {
            get;
            set;
        }
        public MainViewModel()
        {
            cpControl = new ColorPrimaryControl();
            ofControl = new OfertasControl();
        }
        public void LoadColors()
        {
            Colors = new ObservableCollection<ColorsPrimary>(cpControl.Get());
        }
        public void LoadOfertas()
        {
            Ofertas = new ObservableCollection<Oferta>(ofControl.Get());
        }
    }
}
