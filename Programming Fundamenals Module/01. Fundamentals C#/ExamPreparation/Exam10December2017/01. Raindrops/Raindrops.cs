using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Raindrops
{
    class Raindrops
    {
        static void Main(string[] args)
        {
            int region = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());

            decimal sum=0M;

            for (int i = 0; i < region; i++)
            {
                string[] input = Console.ReadLine().Split();

                long raindropsCount = long.Parse(input[0]);
                int squareMeters = int.Parse(input[1]);

                sum += (raindropsCount / (decimal)squareMeters);
            }

            try
            {
                Console.WriteLine($"{sum/density:f3}");
            }
            catch (Exception)
            {
                Console.WriteLine($"{sum}");
            }

        }
    }
}
