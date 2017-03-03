using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double price = -1;


            //

            if (fruit == "banana")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    price = 2.50 * value;
                    //Console.WriteLine("{0:f2}", price);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    price = 2.70 * value;
                    //Console.WriteLine("{0:f2}", price);

                }


            }
            if (fruit == "apple")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    price = 1.20 * value;
                    //Console.WriteLine("{0:f2}", price);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    price = 1.25 * value;
                    //Console.WriteLine("{0:f2}", price);

                }

            }
            if (fruit == "orange")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    price = value * 0.85;
                    //Console.WriteLine("{0:f2}", price);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    price = 0.90 * value;
                    //Console.WriteLine("{0:f2}", price);

                }

            }
            if (fruit == "grapefruit")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    price = 1.45 * value;
                    //Console.WriteLine("{0:f2}", price);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    price = 1.60 * value;
                    //Console.WriteLine("{0:f2}", price);

                }

            }
            if (fruit == "kiwi")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    price = 2.70 * value;
                    //Console.WriteLine("{0:f2}", price);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    price = 3.00 * value;
                    //Console.WriteLine("{0:f2}", price);

                }

            }
            if (fruit == "pineapple")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    price = 5.50 * value;
                    //Console.WriteLine("{0:f2}", price);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    price = 5.60 * value;
                    //Console.WriteLine("{0:f2}", price);

                }

            }
            if (fruit == "grapes")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    price = 3.85 * value;
                    //Console.WriteLine("{0:f2}", price);
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    price = 4.20 * value;


                }

            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price);
            }
            else
            {
                Console.WriteLine("error");
            }

            ////if (price < 0 || fruit != "banana" || fruit != "apple" || fruit != "orange" || fruit != "grapefruit" || fruit != "kiwi" || fruit != "pineapple" || fruit != "grapes")
            //{
            //  Console.WriteLine("error");
            //
            //}
        }

    }
}
