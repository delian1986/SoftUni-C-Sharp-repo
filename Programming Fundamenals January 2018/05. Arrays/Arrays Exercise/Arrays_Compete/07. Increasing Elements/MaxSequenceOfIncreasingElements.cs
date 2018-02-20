using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Increasing_Elements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            //int[]elements=new int[]{3, 2, 3, 4, 2, 2, 4};
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startIndex = 0;
            int currLength = 1;
            int maxStart = 0;
            int maxLength = 1;

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[i - 1])
                {
                    currLength++;
                    if (currLength > maxLength)
                    {
                        maxLength = currLength;
                        maxStart = startIndex;
                    }
                }
                else
                {
                    currLength = 1;
                    startIndex = i;
                }
            }

            for (int i = maxStart; i < maxStart + maxLength; i++)
            {

                Console.Write(elements[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
