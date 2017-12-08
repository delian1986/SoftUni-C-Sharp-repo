using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            var price = 0.0;
            var fruitPri = 0.0;
            var workdays = day == "monday" || day == "tuesday" || day == "thursday" || day == "wednesday" || day == "friday" ;
            var weekend = day == "saturday" || day == "sunday";

            if (workdays==false&&weekend==false)
            {
                Console.WriteLine("error");
                return;
            }

            if (fruit=="banana")
            {

                if (workdays)
                {
                    fruitPri = 2.5;
                }
                else if(weekend)
                {
                    fruitPri = 2.7;
                }
            }
            else if (fruit == "apple")
            {
                if (workdays)
                {
                    fruitPri = 1.2;
                }
                else if(weekend)
                {
                    fruitPri = 1.25;
                }
            }
            else if (fruit == "orange")
            {
                if (workdays)
                {
                    fruitPri = 0.85;
                }
                else if(weekend)
                {
                    fruitPri = 0.9;
                }
            }
            else if (fruit == "grapefruit")
            {
                if (workdays)
                {
                    fruitPri = 1.45;
                }
                else if(weekend)
                {
                    fruitPri = 1.6;
                }
            }
            else if (fruit == "kiwi")
            {
                if (workdays)
                {
                    fruitPri = 2.7;
                }
                else if(weekend)
                {
                    fruitPri = 3;
                }
            }
            else if (fruit == "pineapple")
            {
                if (workdays)
                {
                    fruitPri = 5.5;
                }
                else if (weekend)
                {
                    fruitPri = 5.6;
                }
            }
            else if (fruit == "grapes")
            {
                if (workdays)
                {
                    fruitPri = 3.85;
                }
                else if(weekend)
                {
                    fruitPri = 4.2;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }
            
           
            price = fruitPri * quantity;
            Console.WriteLine($"{price:f2}");

        }
    }
}
