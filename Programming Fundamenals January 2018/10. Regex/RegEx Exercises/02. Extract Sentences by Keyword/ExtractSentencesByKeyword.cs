using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// This pattern matches the whole sentence by given keyword.
/// 
/// </summary>

namespace _02._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main()
        {
            string keyword=Console.ReadLine();
            string text= Console.ReadLine();

            string pattern = $@"(?<=)[^.!?]*\b({keyword})\b[^.!?]*";

            var matches=Regex.Matches(text,pattern).Cast<Match>()
                .Select(x=>x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine,matches));
        }
    }
}