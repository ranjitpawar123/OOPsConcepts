using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public static class Convertor
    {
        public static double ToCelcius(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        public static double ToFahrenheit(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
