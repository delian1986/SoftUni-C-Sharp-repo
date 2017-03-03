using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallMarket
{
    class smallMarket
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string prod = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            if (city =="Sofia")
            {
                if (prod == "coffee")
                {
                    Console.WriteLine(0.50*value);
                }
                else if (prod=="water")
                {
                    Console.WriteLine(0.80*value);
                }
                else if (prod == "beer")
                {
                    Console.WriteLine(1.20*value);
                }
                else if (prod =="sweets")
                {
                    Console.WriteLine(1.45*value);
                }
                else
                {
                    Console.WriteLine(1.60*value);
                }
            }
            if (city == "Plovdiv")
            {
                if (prod == "coffee")
                {
                    Console.WriteLine(0.40 * value);
                }
                else if (prod == "water")
                {
                    Console.WriteLine(0.70 * value);
                }
                else if (prod == "beer")
                {
                    Console.WriteLine(1.15 * value);
                }
                else if (prod == "sweets")
                {
                    Console.WriteLine(1.30 * value);
                }
                else
                {
                    Console.WriteLine(1.50 * value);
                }
            }
            if (city == "Varna")
            {
                if (prod == "coffee")
                {
                    Console.WriteLine(0.45 * value);
                }
                else if (prod == "water")
                {
                    Console.WriteLine(0.70 * value);
                }
                else if (prod == "beer")
                {
                    Console.WriteLine(1.10 * value);
                }
                else if (prod == "sweets")
                {
                    Console.WriteLine(1.35 * value);
                }
                else
                {
                    Console.WriteLine(1.55 * value);
                }
            }
        }
    }
}
