using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int num = int.Parse(Console.ReadLine());
            int[] sumArr = new int[myArr.Length];

            for (int i = 0; i < num; i++)
            {
                int last = myArr.Last();
                for (int j = myArr.Length - 1; j > 0; j--)
                {
                    myArr[j] = myArr[j - 1];
                }
                myArr[0] = last;

                for (int z = 0; z < sumArr.Length; z++)
                {
                    sumArr[z] += myArr[z];
                }
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
