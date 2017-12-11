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
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                for (int j = i; j <= myList.Count ; j++)
                {
                    //if (j==i)
                    //{
                    //    continue;
                    //}
                    if (Math.Abs(myList[i]- myList[j])==num)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);


        }
    }
}
