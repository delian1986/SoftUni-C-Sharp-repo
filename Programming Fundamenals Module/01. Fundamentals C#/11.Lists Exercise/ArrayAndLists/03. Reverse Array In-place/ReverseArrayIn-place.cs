using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < sequence.Length/2; i++)
            {
                int element=sequence[i];
                sequence[i]=sequence[sequence.Length-(i+1)];
                sequence[sequence.Length-(i+1)]=element;
            }

            Console.WriteLine(string.Join(" ",sequence));
        }
    }
}
