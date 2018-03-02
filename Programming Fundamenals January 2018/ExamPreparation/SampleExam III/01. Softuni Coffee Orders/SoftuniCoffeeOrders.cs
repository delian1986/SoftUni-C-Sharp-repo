using System;
using System.Numerics;
using System.Globalization;

namespace _01._Softuni_Coffee_Orders
{
    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            decimal total=0;

            for (int i = 0; i < lines; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime day=DateTime.ParseExact(Console.ReadLine(),"d/M/yyyy",CultureInfo.InvariantCulture);
                long caps=long.Parse(Console.ReadLine());

                int days=DateTime.DaysInMonth(day.Year,day.Month);
                decimal priceOfCoffee=days*price*caps;
                total+=priceOfCoffee;
                Console.WriteLine($"The price for the coffee is: ${priceOfCoffee:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
