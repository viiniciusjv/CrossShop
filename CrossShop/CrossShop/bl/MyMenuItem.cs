using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossShop.bl
{
    public class MyMenuItem : ModelMaster
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
                _Name = value;
                OnPropertyChanged();
            }
        }
        string _ImSource;
        public string ImSource
        {
            get
            {
                return _ImSource;
            }
            set
            {
                _ImSource = value;
                OnPropertyChanged();
            }
        }
        public Type TargetType
        {
            get; set;
        }
    }
}
