using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// This regex matches integer numbers and decimal numbers.
/// </summary>

namespace _05._Match_Numbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string pattern=@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numMatches=Regex.Matches(input,pattern);

            var nums=numMatches.Cast<Match>()
                .Select(x=>x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ",nums));
                

        }
    }
}
