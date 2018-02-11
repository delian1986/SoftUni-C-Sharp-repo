using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Largest_N_Elements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int nums=int.Parse(Console.ReadLine());

            for (int i = 0; i <sequence.Length; i++)
            {
                for (int j = 0; j < sequence.Length-1; j++)
                {
                    if (sequence[j] < sequence[j + 1])
                    {
                        int temp = sequence[j+1];
                        sequence[j+1]=sequence[j];
                        sequence[j]=temp;
                    }

                }
            }

            for (int i = 0; i < nums; i++)
            {
                Console.Write(sequence[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
