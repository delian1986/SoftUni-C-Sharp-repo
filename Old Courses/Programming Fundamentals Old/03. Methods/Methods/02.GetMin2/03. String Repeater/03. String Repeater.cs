using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWord();
            
        }

        static string PrintWord()
        {
            var word = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            var concat = String.Empty;

            for (int i = 0; i < repeat; i++)
            {
                concat += word;
            }
            Console.WriteLine(concat);
            return concat;
        }
    }
}
