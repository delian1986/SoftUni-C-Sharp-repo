using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Jump_Around
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            long sum = 0;

            for (int i = 0; i < sequence.Length;)
            {
                int step = sequence[i];
                sum += sequence[i];
                if (i + step < sequence.Length)
                {
                    i = i + step;
                }
                else if (i-step>=0)
                {
                    i=i-step;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);

        }
    }
}
