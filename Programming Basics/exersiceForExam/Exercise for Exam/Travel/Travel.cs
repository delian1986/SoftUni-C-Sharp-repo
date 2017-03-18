using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Travel
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            var bgCamp = budget * 0.30M;
            var bgHotel = budget * 0.70M;
            var balkCamp = budget * 0.40M;
            var balkHoltel = budget * 0.80M;
            var euHolly = budget * 0.90M;

            string bg = "Bulgaria";
            string balk = "Balkans";
            string eur = "Europe";

            string camp = "Camp";
            string hot = "Hotel";


            if (season == "summer")
            {
                if (budget > 0 && budget <= 100)
                {
                    Console.WriteLine("Somewhere in {0} ", bg);
                    Console.WriteLine("{0} - {1:f2}", camp, bgCamp);
                }
                else if (budget > 100 && budget <= 1000)
                {
                    Console.WriteLine("Somewhere in {0} ", balk);
                    Console.WriteLine("{0} - {1:f2}", camp, balkCamp);

                }

                else if (budget > 1000)
                {
                    Console.WriteLine("Somewhere in {0} ", eur);
                    Console.WriteLine("{0} - {1:f2}", hot, euHolly);

                }
            }
            else
            {
                if (budget > 0 && budget <= 100)
                {
                    Console.WriteLine("Somewhere in {0} ", bg);
                    Console.WriteLine("{0} - {1:f2}", hot, bgHotel);

                }
                else if (budget > 100 && budget <= 1000)
                {
                    Console.WriteLine("Somewhere in {0} ", balk);
                    Console.WriteLine("{0} - {1:f2}", hot, balkHoltel);

                }

                else if (budget > 1000)
                {
                    Console.WriteLine("Somewhere in {0} ", eur);
                    Console.WriteLine("{0} - {1:f2}", hot, euHolly);

                }
            }
        }






    }
}
