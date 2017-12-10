using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] conden = new int[arr.Length-1];

            if (arr.Length==1)
            {
                Console.WriteLine(arr[0]);
                return;
            }

            for (int i = 0; i <arr.Length; i++)
            {
                for (int j = 0; j < conden.Length; j++)
                {
                    conden[j] = arr[j] + arr[j + 1];
                }
                arr = conden;
            }
            Console.WriteLine(conden[0]);
        }
    }
}