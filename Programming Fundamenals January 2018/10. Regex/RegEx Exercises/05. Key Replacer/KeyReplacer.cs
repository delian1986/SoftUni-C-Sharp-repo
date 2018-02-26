using System;
using System.Text.RegularExpressions;

/// <summary>
/// https://judge.softuni.bg/Contests/Compete/Index/430#4
/// </summary>
namespace _05._Key_Replacer
{
    class KeyReplacer
    {
        static void Main()
        {
            string keys = Console.ReadLine();
            string text = Console.ReadLine();

            //Pattern for finding keys.
            string keysPattern = @"^(?<start>[A-Za-z]+)([\|\<\\])(?<ent>.*)([\|\<\\])(?<end>[A-Za-z]+)";

            string start = string.Empty;
            string end = string.Empty;

            foreach (Match key in Regex.Matches(keys, keysPattern))
            {
                //Assign start and end groups.
                start = key.Groups["start"].Value;
                end = key.Groups["end"].Value;
            }

            //Pattern for finding the word that will be trimmed.
            string patternForText = $@"({start})(?<word>.*?)({end})";
            string result = string.Empty;

            foreach (Match m in Regex.Matches(text, patternForText))
            {
                string word = m.Groups["word"].Value;
                
                //Adding word to result string.
                result += word;
            }

            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
