using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// This expression matches dates. E.g. 13/Jul/1928 ; 10-Nov-1934.
/// https://judge.softuni.bg/Contests/Practice/Index/452#3
/// </summary>

namespace _04._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
             string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            string input=Console.ReadLine();

            foreach (Match date in Regex.Matches(input,pattern))
            {
                string day=date.Groups["day"].Value;
                string month=date.Groups["month"].Value;
                string year=date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
