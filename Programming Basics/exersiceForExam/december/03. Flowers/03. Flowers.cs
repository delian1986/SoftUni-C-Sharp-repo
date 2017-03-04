using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var hriz = int.Parse(Console.ReadLine());
            var rose = int.Parse(Console.ReadLine());
            var lale = int.Parse(Console.ReadLine());
            var totFlow = hriz + rose + lale;
            string seas = Console.ReadLine().ToLower();
            string holy = Console.ReadLine().ToLower();
            double totPrice = 0;

            if (seas=="spring" || seas=="summer")
            {
                double hrizPrice = hriz*2.00;
                double rosePrice = rose*4.10;
                double lalePrice = lale*2.50;
                totPrice = hrizPrice + rosePrice + lalePrice;
                if (holy == "y")
                {
                    totPrice = totPrice + (totPrice * 0.15);
                }
                if (lale>=7 && seas=="spring")
                {
                    totPrice = totPrice - (totPrice * 0.05);
                }
               
                if (totFlow>20)
                {
                    totPrice = totPrice - (totPrice * 0.20);
                }
                totPrice += 2;

            }

            else if (seas=="autumn"||seas=="winter")
            {
                double hrizPrice = hriz * 3.75;
                double rosePrice = rose * 4.50;
                double lalePrice = lale * 4.15;
                totPrice = hrizPrice + rosePrice + lalePrice;
                if (holy=="y")
                {
                    totPrice = totPrice + (totPrice * 0.15);
                }
                if (rose >= 10 && seas == "winter")
                {
                    totPrice = totPrice - (totPrice * 0.10);
                }
                if (totFlow > 20)
                {
                    totPrice = totPrice - (totPrice * 0.20);
                }
                totPrice += 2;
            }
            Console.WriteLine("{0:f2}",totPrice);
        }
    }
}
