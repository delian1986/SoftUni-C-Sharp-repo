using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split('|').ToList();

            List<string> result = new List<string>();
            for (int i = 0; i < myList.Count; i++)
            {
                result.Insert(0, myList[i]);

            }

            

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
