using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var largestThree=sequence.OrderByDescending(x=>x).Take(3);

            Console.WriteLine(string.Join(" ",largestThree));
        }
    }
}
