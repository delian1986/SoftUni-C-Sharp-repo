using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Grab_and_Go
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            List<long> sequence = Console.ReadLine().Split().Select(long.Parse).ToList();
            long numToSearchFor = long.Parse(Console.ReadLine());

            if (!sequence.Contains(numToSearchFor))
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                long sum = CalculateSumOfNeededElements(sequence, numToSearchFor);
                Console.WriteLine(sum);
            }

        }

        private static long CalculateSumOfNeededElements(List<long> sequence, long numToSearchFor)
        {
            long sum = 0;
            long index = sequence.LastIndexOf(numToSearchFor);
            for (int i = 0; i < index; i++)
            {
                sum += sequence[i];
            }

            return sum;
        }
    }
}
