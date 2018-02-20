using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MinMaxSumAvg
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[]sequence=new int[n];

            for (int i = 0; i <n; i++)
            {
                int inputNum=int.Parse(Console.ReadLine());
                sequence[i]=inputNum;
            }
            
            Console.WriteLine($"Sum = {sequence.Sum()}");
            Console.WriteLine($"Min = {sequence.Min()}");
            Console.WriteLine($"Max = {sequence.Max()}");
            Console.WriteLine($"Average = {sequence.Average()}");

        }
    }
}
