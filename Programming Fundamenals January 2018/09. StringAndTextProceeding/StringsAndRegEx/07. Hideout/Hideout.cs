using System;
using System.Text.RegularExpressions;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/585#6
/// </summary>

namespace _07._Hideout
{
    class Hideout
    {
        static void Main()
        {
            string map = Console.ReadLine();
            int startIndex = 0;
            int matchLength = 0;
            bool hideoutFound = false;

            while (!hideoutFound)
            {
                //Decription input.
                string[] key = Console.ReadLine().Split();

                string symbol = key[0];
                string minCount = key[1];

                string pattern = $@"\{symbol}{{{minCount},}}";
                var regexHideout=new Regex(pattern);

                if (regexHideout.IsMatch(map))
                {
                    var hideout=regexHideout.Match(map);
                    startIndex = hideout.Index;
                    matchLength = hideout.Length;
                    hideoutFound = true;
                }

            }

            Console.WriteLine($"Hideout found at index {startIndex} and it is with size {matchLength}!");
        }
    }
}
