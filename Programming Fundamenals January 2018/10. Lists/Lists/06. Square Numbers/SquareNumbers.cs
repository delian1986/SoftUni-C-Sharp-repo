using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Square_Numbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums= Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> squares= new List<int>();

            foreach (var num in nums)
            {
                if (Math.Sqrt(num)==(int)Math.Sqrt(num))
                {
                    squares.Add(num);
                }
            }
            squares.Sort();
            squares.Reverse();
            Console.WriteLine(string.Join(" ",squares));
        }
    }
}
