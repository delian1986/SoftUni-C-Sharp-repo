using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int grpSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            decimal hallPrice;
            string hall = String.Empty;
            decimal pricePerPerson = 0m;

            if (grpSize > 121)
            {
                Console.WriteLine($"We do not have an appropriate hall.");
            }

            else if (grpSize <= 50 && grpSize > 0)
            {
                hall = "Small Hall";

                if (package == "Normal")
                {
                    hallPrice = 3000 - (3000 * 0.05M);
                    pricePerPerson = hallPrice / grpSize;
                }
                else if (package == "Gold")
                {
                    hallPrice = 3250 - (3250 * 0.1M);
                    pricePerPerson = hallPrice / grpSize;

                }
                else
                {
                    hallPrice = 3500 - (3500 * 0.15M);
                    pricePerPerson = hallPrice / grpSize;
                }
            }
            else if (grpSize <= 100 && grpSize > 50)
            {
                hall = "Terrace";
                hallPrice = 5000;

                if (package == "Normal")
                {
                    hallPrice = 5500 - (5500 * 0.05M);
                    pricePerPerson = hallPrice / grpSize;
                }
                else if (package == "Gold")
                {
                    hallPrice = 5750 - (5750 * 0.1M);
                    pricePerPerson = hallPrice / grpSize;

                }
                else
                {
                    hallPrice = 6000 - (6000 * 0.15M);
                    pricePerPerson = hallPrice / grpSize;
                }
            }
            else if (grpSize <= 120 && grpSize > 100)
            {
                hall = "Great Hall";
                hallPrice = 7500;
                if (package == "Normal")
                {
                    hallPrice = 8000 - (8000 * 0.05M);
                    pricePerPerson = hallPrice / grpSize;
                }
                else if (package == "Gold")
                {
                    hallPrice = 8250 - (8250 * 0.1M);
                    pricePerPerson = hallPrice / grpSize;

                }
                else
                {
                    hallPrice = 8500 - (8500 * 0.15M);
                    pricePerPerson = hallPrice / grpSize;
                }
            }

            if (hall.Length > 0)
            {

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

            }
        }
    }
}
