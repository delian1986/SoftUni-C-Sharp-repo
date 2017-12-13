using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] text1 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            bool first = false;
            bool sec = false;

            if (text.Length == text1.Length)
            {
                if (text[0] < text1[0])
                {
                    first = true;
                }
                else
                {
                    sec = false;
                }
            }

            else
            {
                if (text.Length<text1.Length)
                {
                    first = true;
                }
                else
                {
                    sec = true;
                }
            }

            if (first)
            {
                Console.WriteLine(string.Join("",text));
                Console.WriteLine(string.Join("", text1));

            }
            else
            {
                Console.WriteLine(string.Join("", text1));
                Console.WriteLine(string.Join("", text));

            }
        }
    }
}
