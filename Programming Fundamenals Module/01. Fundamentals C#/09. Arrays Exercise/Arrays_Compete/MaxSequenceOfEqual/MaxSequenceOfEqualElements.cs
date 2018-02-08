using System;
using System.Linq;

namespace MaxSequenceOfEqual
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int maxCount = 1;
            int num = 0;

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] == elements[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    num = elements[i];
                }
            }
            if (maxCount == 1)
            {
                num = elements[0];
            }

            Console.WriteLine(string.Concat(Enumerable.Repeat((num + " "), maxCount)));
        }
    }
}
