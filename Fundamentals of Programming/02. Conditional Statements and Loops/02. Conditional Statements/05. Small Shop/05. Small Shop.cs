using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var value = double.Parse(Console.ReadLine());

            var cofee = 0.0;
            var water = 0.0;
            var beer = 0.0;
            var sweets = 0.0;
            var peanuts = 0.0;
            var result = 0.0;

            if (city=="sofia")
            {
                if (product == "coffee")
                {
                    cofee = 0.5;
                    result = cofee * value;
                }
                else if (product=="water")
                {
                    water = 0.8;
                    result = water * value;
                }
                else if (product=="beer")
                {
                    beer = 1.2;
                    result = beer * value;
                }
                else if (product=="sweets")
                {
                    sweets = 1.45;
                    result = sweets * value;
                }
                else if (product=="peanuts")
                {
                    peanuts = 1.6;
                    result = peanuts * value;
                }
            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    cofee = 0.4;
                    result = cofee * value;
                }
                else if (product == "water")
                {
                    water = 0.7;
                    result = water * value;
                }
                else if (product == "beer")
                {
                    beer = 1.15;
                    result = beer * value;
                }
                else if (product == "sweets")
                {
                    sweets = 1.30;
                    result = sweets * value;
                }
                else if (product == "peanuts")
                {
                    peanuts = 1.5;
                    result = peanuts * value;
                }
            }
            else if (city == "varna")
            {
                if (product == "coffee")
                {
                    cofee = 0.45;
                    result = cofee * value;
                }
                else if (product == "water")
                {
                    water = 0.7;
                    result = water * value;
                }
                else if (product == "beer")
                {
                    beer = 1.1;
                    result = beer * value;
                }
                else if (product == "sweets")
                {
                    sweets = 1.35;
                    result = sweets * value;
                }
                else if (product == "peanuts")
                {
                    peanuts = 1.55;
                    result = peanuts * value;
                }
            }
            Console.WriteLine(result);
        }
    }
}
