using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int counter = 0;

            int multiplyingNums = 0;
            int totalSum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    multiplyingNums = (i * j) * 3;
                    if (totalSum>=stop)
                    {
                        break;
                    }
                    totalSum += multiplyingNums;
                    counter++;

                }
                if (totalSum>=stop)
                {
                    break;
                }
            }
            Console.WriteLine($"{counter} combinations");

            if (totalSum>=stop)
            {
                Console.WriteLine($"Sum: {totalSum} >= {stop}");
            }
            else
            {
                Console.WriteLine($"Sum: {totalSum}"); 
            }
        }
    }
}
