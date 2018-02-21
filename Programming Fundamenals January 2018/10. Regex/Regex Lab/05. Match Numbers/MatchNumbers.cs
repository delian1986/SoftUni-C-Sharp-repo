using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Match_Numbers
{
    class Program
    {
        private static object regex;

        static void Main()
        {
            string text=Console.ReadLine();
            string pattern=@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numRegex=Regex.Matches(text,pattern);

            var nums=numRegex.Cast<Match>()
                .Select(x=>x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
