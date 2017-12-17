using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries)
    .Select(s => s.TrimEnd())
    .ToList();

            List<string> result = new List<string>().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                result.Insert(0, input[i]);
            }
            


            Console.WriteLine(string.Join(" ", result));
        }
    }
}
