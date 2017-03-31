using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 04:
//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int []arr = new int[n];
            var count = 1;
            var maxCount = 1;

            for (int i = 0; i <arr.Length; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());

                if (i>0&&arr[i]==arr[i-1])
                {
                    count++;
                    if (count>maxCount)
                    {
                        maxCount=count;

                    }
                }
                else
                {
                    count = 1;
                }
                
            }
            var res = Math.Max(count, maxCount);
            Console.WriteLine(res);
        }
    }
}
