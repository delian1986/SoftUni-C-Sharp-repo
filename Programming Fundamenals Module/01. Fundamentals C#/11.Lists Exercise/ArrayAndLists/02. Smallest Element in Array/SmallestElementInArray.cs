using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Smallest_Element_in_Array
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min=int.MaxValue;
            
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i]<min)
                {
                    min=sequence[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
