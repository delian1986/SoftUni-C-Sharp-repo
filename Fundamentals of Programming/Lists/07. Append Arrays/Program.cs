using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split("|");

            List<string> result = new List<string>();

            foreach (var item in input)
            {
                List<string> temp = item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                result.InsertRange(0, temp);

            }

            Console.WriteLine(string.Join(" ", result));


        }
    }
}
