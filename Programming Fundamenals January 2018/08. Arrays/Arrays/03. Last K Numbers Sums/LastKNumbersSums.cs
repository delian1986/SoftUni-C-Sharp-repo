using System;

namespace _03._Last_K_Numbers_Sums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int nums = 6; //int.Parse(Console.ReadLine());
            int k = 3; //int.Parse(Console.ReadLine());

            int[] sequence = new int[nums];

            sequence[0] = 1;
            sequence[1] = 1;
            sequence[2] = 2;

            for (int i = 3; i < sequence.Length; i++)
            {
                if (k > i)
                {
                    sequence[i]=summKelem(sequence, i);
                }
                else
                {
                    sequence[i] =+ summKelem(sequence,i);

                }
            }

            foreach (var num in sequence)
            {
                Console.Write(num+" ");
            }
        }

        private static int summKelem(int[] sequence, int i)
        {
            for (int j = 0; j < i; j++)
            {
                sequence[i] += sequence[j];
            }
            return sequence[i];
        }
    }
}
