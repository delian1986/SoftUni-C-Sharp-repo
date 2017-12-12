using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            if (myList.Count <= 1)
            {
                Console.WriteLine(($"{{ {myList[0]} }}"));
                return;
            }

            else if (myList.Count % 2 == 0)
            {
                for (int i= myList.Count / 2 - 1; i <= myList.Count / 2; i++)
                {
                    result.Add(myList[i]);
                }
            }
            else
            {
                for (int i = myList.Count/2-1; i <= myList.Count/2+1; i++)
                {
                    result.Add(myList[i]);

                }
            }

            Console.Write("{ ");
            Console.Write(string.Join(", ",result));
            Console.WriteLine(" }");
        }
    }
}
