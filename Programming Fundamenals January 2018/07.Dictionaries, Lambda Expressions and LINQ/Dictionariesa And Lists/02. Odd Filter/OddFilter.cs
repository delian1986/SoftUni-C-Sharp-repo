using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// This is console program which removes all odd numbers. After that the program substract 1 from all smaller than average or add 1 to all
/// larger than average.
/// https://judge.softuni.bg/Contests/Practice/Index/582#1
/// </summary>

namespace _02._Odd_Filter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            List<int>sequence=Console.ReadLine().Split().Select(int.Parse).Where(x=>x%2==0).ToList();

            var avg=sequence.Average();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i]<=avg)
                {
                    sequence[i]--;
                }
                else
                {
                    sequence[i]++;
                }
            }
            Console.WriteLine(string.Join(" ",sequence));

        }
    }
}
