using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public static class Calc
    {
        public static double summ(string numberone, string numbertwo)
        {
            return Convert.ToDouble(Convert.ToInt32(numberone) + Convert.ToInt32(numbertwo));
        }
        public static double divide(string numberone, string numbertwo)
        {
            return Convert.ToDouble(Convert.ToInt32(numberone) / Convert.ToInt32(numbertwo));
        }
        public static double multiply(string numberone, string numbertwo)
        {
            return Convert.ToDouble(Convert.ToInt32(numberone) * Convert.ToInt32(numbertwo));
        }
        public static double minus(string numberone, string numbertwo)
        {
            return Convert.ToDouble(Convert.ToInt32(numberone) - Convert.ToInt32(numbertwo));
        }
    }
}
