using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Sort_Array_nsertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < sequence.Length-1; i++)
            {
                for (int j = i+ 1; j > 0; j--)
                {
                    if (sequence[j-1]>sequence[j])
                    {
                        int temp=sequence[j-1];
                        sequence[j-1]=sequence[j];
                        sequence[j]=temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",sequence));

        }
    }
}
