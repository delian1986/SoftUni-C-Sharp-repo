using System;
using System.Linq;

namespace _05._Rounding_Numbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            decimal[]numsToRound=Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            foreach (var num in numsToRound)
            {
                Console.WriteLine($"{num} => {Math.Round(num,MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
