using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01._Censorship
{
    class Censorship
    {
        static void Main()
        {
            string pattern = $@"{Console.ReadLine()}";
            string text = Console.ReadLine();
            string replacement = string.Concat(Enumerable.Repeat("*", pattern.Length));

            text = Regex.Replace(text, pattern, replacement);
            Console.WriteLine(text);

        }
    }
}
