using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/// <summary>
/// This program match two words starting with capital letter.
/// https://judge.softuni.bg/Contests/Practice/Index/452#0
/// </summary>

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matchedNames=Regex.Matches(names,pattern);

            List<string>namesList=new List<string>();

            foreach (Match matchedName in matchedNames)
            {
                namesList.Add(matchedName.Value.Trim());
            }

            Console.WriteLine(string.Join(" ",namesList));
        }
    }
}
