using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Match_Hexadecimal_Numbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            string pattern=@"(0x)?[0-9A-F]+\b";

            var colorMatches=Regex.Matches(text,pattern);

            var matches=colorMatches.Cast<Match>()
                .Select(x=>x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ",matches));
        }
    }
}
