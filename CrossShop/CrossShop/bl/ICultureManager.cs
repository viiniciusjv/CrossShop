using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShop.bl
{
    public interface ICultureManager
    {
        System.Globalization.CultureInfo CurrentCulture { get; set; }
        System.Globalization.CultureInfo CurrentUICulture { get; set; }
    }
}
