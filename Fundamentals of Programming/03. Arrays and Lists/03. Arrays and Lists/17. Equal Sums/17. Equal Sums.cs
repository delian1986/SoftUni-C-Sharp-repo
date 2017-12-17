using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool found = false;

            for (int i = 0; i < inputLine.Length; i++)
            {
                var left = 0;
                var right = 0;
                for (int j = 0; j < i; j++)
                {
                    left += inputLine[j];
                }
                for (int k = i + 1; k < inputLine.Length; k++)
                {
                    right += inputLine[k];
                }

                if (left == right)
                {
                    Console.WriteLine(i);
                    found = true;
                }

            }

            if (found==false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
