using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Count_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int counter = 0;
            int index = text.IndexOf(pattern);

            while (index != -1)
            {

                counter++;
                index = text.IndexOf(pattern, index + 1);

            }
            Console.WriteLine(counter);
        }
    }
}
