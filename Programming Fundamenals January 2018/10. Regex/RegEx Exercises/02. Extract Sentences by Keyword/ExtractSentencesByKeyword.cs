using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// This pattern matches the whole sentence by given keyword.
/// https://judge.softuni.bg/Contests/Compete/Index/430#1
/// </summary>

namespace _02._Extract_Sentences_by_Keyword
{
    class ExtractSentencesByKeyword
    {
        static void Main()
        {
            string keyword=Console.ReadLine();
            string text= Console.ReadLine();

            //Pattern for extracting the whose sentence where is 
            //keyword contained.
            string pattern = $@"(?<=)[^.!?]*\b({keyword})\b[^.!?]*";

            var matches=Regex.Matches(text,pattern).Cast<Match>()
                .Select(x=>x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine,matches));
        }
    }
}