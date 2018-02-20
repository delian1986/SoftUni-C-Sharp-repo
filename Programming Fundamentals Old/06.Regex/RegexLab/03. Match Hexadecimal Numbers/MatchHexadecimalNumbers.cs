using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// This pattern matches hex numbers. e.g. 0x1F , 1F etc.
/// https://judge.softuni.bg/Contests/Practice/Index/452#2
/// </summary>

namespace _03._Match_Hexadecimal_Numbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern=@"(?:0[xX])?[0-9a-fA-F]+\b";

            //Pring with List.
            //List<string>hexNums=new List<string>();
            //
            //foreach (Match num in Regex.Matches(input,pattern))
            //{
            //    hexNums.Add(num.Value);
            //}

            //Print with LINQ.
            var hexMatches=Regex.Matches(input,pattern);
            var hexNums=hexMatches.Cast<Match>()
                .Select(x=>x.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(" ",hexNums)); 

        }
    }
}
