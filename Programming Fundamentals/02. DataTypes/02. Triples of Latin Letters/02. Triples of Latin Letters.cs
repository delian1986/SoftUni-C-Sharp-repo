using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = n + 'a';

            for (char first = 'a'; first < num; first++)
            {
                for (char sec = 'a'; sec < num; sec++)
                {
                    for (char trd = 'a'; trd < num; trd++)
                    {
                        Console.WriteLine($"{first}{sec}{trd}");
                    }
                }
            }
        }
    }
}
