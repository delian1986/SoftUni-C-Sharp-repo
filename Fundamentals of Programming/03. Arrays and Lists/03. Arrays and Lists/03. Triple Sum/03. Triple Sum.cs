using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool found = false;

            for (int i = 0; i < myList.Count; i++)
            {
                for (int j = i+1; j < myList.Count; j++)
                {
                    var sum = myList[i] + myList[j];
                    if (myList.Contains(sum))
                    {
                        Console.WriteLine($"{myList[i]} + {myList[j]} == {sum}");
                        found = true;
                    }

                }
            }
            if (found == false)
            {
                Console.WriteLine("No");
            }

        }
    }
}

