using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Sum_Reversed_Numbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split().ToList();
            string revNums=string.Empty;

            List<int> reversed = new List<int>();

            foreach (var num in sequence)
            {
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    revNums+=num[i];
                }
                
                reversed.Add(int.Parse(revNums));
                revNums=string.Empty;
            }
            Console.WriteLine(reversed.Sum());

        }
    }
}
