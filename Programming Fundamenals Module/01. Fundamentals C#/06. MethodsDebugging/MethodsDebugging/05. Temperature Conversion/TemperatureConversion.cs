using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Temperature_Conversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double fahrenheit=double.Parse(Console.ReadLine());

            double convertedNum=ConvertFartToCelsius(fahrenheit);

            Console.WriteLine($"{convertedNum:f2}");
        }

        private static double ConvertFartToCelsius(double fahrenheit)
        {
            return (fahrenheit-32)*5/9;
        }
    }
}

