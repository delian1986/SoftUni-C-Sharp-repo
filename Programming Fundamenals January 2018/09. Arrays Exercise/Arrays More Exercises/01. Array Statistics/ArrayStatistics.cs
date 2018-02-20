using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine("Min = {0}",sequence.Min());
            Console.WriteLine("Max = {0}",sequence.Max());
            Console.WriteLine("Sum = {0}",sequence.Sum());
            Console.WriteLine("Average = {0}",sequence.Average());

        }

    }
}
