using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Match_Dates
{
    class MatchDates
    {
        public static object REgex { get; private set; }

        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            string pattern = @"\b(?<day>[\d]{2})(?<delim>[\/.-])(?<month>[A-Z]{1}[a-z]{2})(\k<delim>)(?<year>[\d]{4})\b";

            var regexDates=Regex.Matches(text,pattern);

            foreach (Match date in regexDates)
            {
                var day = date.Groups["day"].Value;
                var month=date.Groups["month"].Value;
                var year= date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
