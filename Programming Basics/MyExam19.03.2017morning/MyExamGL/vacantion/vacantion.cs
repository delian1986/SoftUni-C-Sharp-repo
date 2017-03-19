using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacantion
{
    class vacantion
    {
        static void Main(string[] args)
        {
            var budg = decimal.Parse(Console.ReadLine());
            var seas = Console.ReadLine().ToLower();

            string place = String.Empty;
            string destination = String.Empty;
            var cost = 0m;
            if (budg<=1000)
            {
                place = "Camp";
                if (seas=="summer")
                {
                    destination = "Alaska";
                    cost = budg * 0.65m;
                }
                else if (seas=="winter")
                {
                    destination = "Morocco";
                    cost = budg * 0.45m;
                }
            }
            else if (budg>1000&&budg<=3000)
            {
                place = "Hut";
                if (seas=="summer")
                {
                    destination = "Alaska";
                    cost = budg * 0.80m;
                }
                else if (seas=="winter")
                {
                    destination = "Morocco";
                    cost = budg * 0.60m;
                }
            }
            else if (budg>3000)
            {
                place = "Hotel";
                if (seas=="summer")
                {
                    destination = "Alaska";
                    cost = budg * 0.90m;
                }
                else if (seas=="winter")
                {
                    destination = "Morocco";
                    cost = budg * 0.90m;

                }
            }

            Console.WriteLine($"{destination} - {place} - {cost:f2}");
        }
    }
}
