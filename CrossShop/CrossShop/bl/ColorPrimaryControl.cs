using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossShop.bl
{
    public class ColorPrimaryControl
    {
        public List<ColorsPrimary> Get()
        {
            List<ColorsPrimary> lst = new List<ColorsPrimary>();
            for (int i = 0; i < 4; i++)
            {
                Color cl = new Xamarin.Forms.Color(0, 0,1d/(i+1d) );
                lst.Add(new ColorsPrimary() { Color = cl, Name = i.ToString() });
            }
            return lst;

        }
    }
}
