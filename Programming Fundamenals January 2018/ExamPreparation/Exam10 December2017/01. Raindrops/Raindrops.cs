using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Raindrops
{
    class Raindrops
    {
        static void Main()
        {
            int amountRegions = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());

            decimal sum=0M;

            for (int i = 0; i < amountRegions; i++)
            {
                string[] input = Console.ReadLine().Split();

                long raindropsCount = long.Parse(input[0]);
                long squareMeters = int.Parse(input[1]);

                sum += (raindropsCount / (decimal)squareMeters);
            }

            if (density!=0)
            {
                sum=sum/density;
            }

            Console.WriteLine($"{sum:f3}");

        }
    }
}
