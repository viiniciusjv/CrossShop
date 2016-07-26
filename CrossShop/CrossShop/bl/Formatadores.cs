using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShop.bl
{
    public static class Formatadores
    {
        public static string MinutesToTime(int Minutes)
        {
            string strTime = string.Empty;
            TimeSpan ts = new TimeSpan(0, Minutes, 0);
            if (ts.Days > 0)
                strTime += ts.Days.ToString() + "D";
            if (ts.Hours > 0)
                strTime += ts.Hours.ToString() + "H";
            if (ts.Minutes > 0)
                strTime += ts.Minutes.ToString() + "M";

            return strTime;
        }
    }
}
