using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            arr[0] = 1;


            int[] seq = arr;

            for (int i = 1; i < arr.Length; i++)
            {
                int start = Math.Max(0, i - k);
                int end = i - 1;
                int sum = 0;

                for (int j = start; j <= end; j++)
                {
                    sum += arr[j];

                }
                arr[i] = sum;
            }

            for (int i = 0; i < seq.Length; i++)
            {
                Console.Write(seq[i] + " ");

            }
        }
    }
}
