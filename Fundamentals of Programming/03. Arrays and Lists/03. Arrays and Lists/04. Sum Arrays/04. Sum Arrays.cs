using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();

            int[] bigArr = new int[Math.Max(arr1.Length, arr2.Length)];

            for (int i = 0; i < bigArr.Length; i++)
            {
                var sum = arr1[i % arr1.Length] + arr2[i % arr2.Length];
                Console.Write($"{sum} ");
            }
            Console.WriteLine();

        }
    }
}
