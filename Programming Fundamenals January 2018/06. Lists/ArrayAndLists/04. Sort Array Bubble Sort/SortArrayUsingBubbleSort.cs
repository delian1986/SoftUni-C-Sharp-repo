using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Sort_Array_Bubble_Sort
{
    class SortArrayUsingBubbleSort
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = i+1; j < sequence.Length; j++)
                {
                    if (sequence[i]>sequence[j])
                    {
                        int temp= sequence[j];
                        sequence[j]=sequence[i];
                        sequence[i]=temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",sequence));
        }
    }
}
