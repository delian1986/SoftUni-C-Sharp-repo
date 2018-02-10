using System;
using System.Collections.Generic;
using System.Linq;

// source https://www.youtube.com/watch?v=N-AlTemCnMc&t=24m55s
namespace _04._LongestSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] length = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            List<int> longestSeq = new List<int>();

            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(sequence[lastIndex]);
                lastIndex=prev[lastIndex];
            }
            longestSeq.Reverse();

            Console.WriteLine(string.Join(" ",longestSeq));
        }


    }
}
