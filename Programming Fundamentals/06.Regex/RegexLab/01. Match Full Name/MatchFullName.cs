using System;
using System.Text.RegularExpressions;

/// <summary>
/// This program match two words starting with capital letter.
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

            foreach (Match matchedName in matchedNames)
            {
                Console.WriteLine(matchedName.Value+" ");
            }
        }
    }
}
