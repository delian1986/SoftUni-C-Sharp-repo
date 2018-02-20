using System;
using System.Text.RegularExpressions;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            var pattern = @"(?<name>[A-Za-z]{1})(?<num>\d+)(?<last>[A-Za-z]{1})";
            var regex = new Regex(pattern);
            for (int i = 0; i < input.Length; i++)
            {
                decimal left = 0;
                decimal right = 0;
                Match match = regex.Match(input[i]);

                char first = char.Parse(match.Groups["name"].Value);
                long num = long.Parse(match.Groups["num"].Value);
                char last = char.Parse(match.Groups["last"].Value);

                if (i % 2 == 0)
                {
                    left += num / (first - 96);
                    left  += (last - 96);
                }
                else
                {
                    right += (first - 96) * num;
                    right -= (last - 96);
                }
                sum += left + right;

            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
