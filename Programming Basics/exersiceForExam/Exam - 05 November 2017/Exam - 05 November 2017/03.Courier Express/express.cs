using System;

namespace _03.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var distance = int.Parse(Console.ReadLine());

            var price = 0.0;
            var extra = 0.0;

            if (weight < 1)
            {
                price = distance * 0.03;
            }
            else if (weight >= 1 && weight <= 10)
            {
                price = distance * 0.05;

            }
            else if (weight >= 11 && weight <= 40)
            {
                price = distance * 0.1;

            }
            else if (weight >= 41 && weight <= 90)
            {
                price = distance * 0.15;

            }
            else
            {
                price = distance * 0.2;
            }



            if (type == "express")
            {
                if (weight < 1)
                {
                    extra = 0.80 * 0.03;
                    price += (weight * extra) * distance;
                }
                else if (weight >= 1 && weight <= 10)
                {
                    extra = 0.40 * 0.05;
                    price += (weight * extra) * distance;

                }
                else if (weight >= 11 && weight <= 40)
                {
                    extra = 0.05 * 0.1;
                    price += (weight * extra) * distance;

                }
                else if (weight >= 41 && weight <= 90)
                {
                    extra = 0.02 * 0.15;
                    price += (weight * extra) * distance;

                }
                else
                {
                    extra = 0.01 * 0.2;
                    price += (weight * extra) * distance;
                }

            }

            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {price:f2} lv.");



        }
    }
}
