using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myList = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < myList.Length; i++)
            {
                for (int j = i; j < myList.Length; j++)
                {
                    if ((myList[i] - myList[j]) == num || myList[j] - myList[i] == num)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);


        }
    }
}
