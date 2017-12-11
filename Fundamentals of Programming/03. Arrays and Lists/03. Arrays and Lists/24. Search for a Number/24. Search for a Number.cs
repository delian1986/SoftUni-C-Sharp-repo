using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numsList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i <myList.Count; i++)
            {
                if (i<numsList[0])
                {
                    result.Add(myList[i]);
                }
                else
                {
                    break;
                }
            }

            result.RemoveRange(0, numsList[1]);

            bool found = false;

            foreach (var item in result)
            {
                if (item==numsList[2])
                {
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

            

            


        }
    }
}
