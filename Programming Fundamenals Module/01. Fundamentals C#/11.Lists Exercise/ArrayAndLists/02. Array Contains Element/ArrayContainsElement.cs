using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]sequence=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int element=int.Parse(Console.ReadLine());

            bool isFound=false;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i]==element)
                {
                    isFound=true;
                }
            }

            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
