using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price = CalculatePrice(profession);
            TotalPricePrinter(profession, quantity, price);

        }

        private static decimal CalculatePrice(string profession)
        {
            decimal price = 0M;

            switch (profession)
            {
                case "Athlete":
                    price = 0.7M;
                    break;

                case "Businessman":
                case "Businesswoman":
                    price = 1;
                    break;
                case "SoftUni Student":
                    price = 1.7M;
                    break;

                default:
                    price = 1.2M;
                    break;
            }

            return price;
        }

        private static void TotalPricePrinter(string profession, int quantity, decimal price)
        {
            Console.WriteLine($"The {profession} has to pay {quantity *price:f2}.");
        }
    }
}
