using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling_At_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal lightYearsToKm = 9450000000000m;
            decimal speedOfLight = 300000m;

            decimal result = (lightYearsToKm / speedOfLight) * lightYears;

            TimeSpan time = TimeSpan.FromSeconds((double)result);
            var weeks = time.Days /7;
            var days = time.Days % 7;
            var hours = time.Hours;
            var min = time.Minutes;
            var sec = time.Seconds;

            Console.WriteLine($"{weeks} weeks\n{days} days\n{hours} hours\n{min} minutes\n{sec} seconds");


        }
    }
}
