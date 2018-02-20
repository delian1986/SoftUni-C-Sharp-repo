using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split().ToArray();

            SortedDictionary<double, int> dictOfRealNums = new SortedDictionary<double, int>();

            foreach (var num in sequence)
            {
                double realNum = double.Parse(num);
                if (!dictOfRealNums.ContainsKey(realNum))
                {
                    dictOfRealNums.Add(realNum, 0);
                }
                dictOfRealNums[realNum] += 1;
            }

            foreach (var num in dictOfRealNums)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
