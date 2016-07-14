using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossShop.bl
{
    public class ColorsPrimary : ModelMaster
    {
        string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnPropertyChanged();
                _Name = value;
            }
        }

        Color _Color;
        public Color Color
        {
            get
            {
                return _Color;
            }
            set
            {
                OnPropertyChanged();
                _Color = value;
            }
        }
        public ColorsPrimary()
        {
            Name = string.Empty;           
        }



    }
}
