using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class TempCalcs
    {
        public static void PrintAndConvertTemp()
        {
            Console.WriteLine("Zadej teplotu ve F: ");
            var inpstr = Console.ReadLine();
            double temp = double.Parse(inpstr);
            Console.WriteLine($"Teplota je {FahrenheitToCelsius(temp)} °C");
        }

        static double FahrenheitToCelsius(double temp)
        {
            return Math.Round(((temp - 32) / 1.8), 2);
        }
    }
}
