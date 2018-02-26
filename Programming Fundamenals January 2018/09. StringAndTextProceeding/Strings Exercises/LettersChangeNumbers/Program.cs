using System;
using System.Text.RegularExpressions;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries);

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
                    //UpperCase.
                    if (first >= 65 && first <= 90)
                    {
                        left += (decimal)num / (first - 64);
                    }
                    //LowerCase.
                    else
                    {
                        left += (decimal)num * (first - 96);
                    }

                    //UpperCase.
                    if (last >= 65 && last <= 90)
                    {
                        left-= (last - 64);
                    }
                    //LowerCase.
                    else
                    {
                        left+= (last - 96);
                    }
                }
                else
                {
                    //UpperCase.
                    if (first >= 65 && first <= 90)
                    {
                        right += (decimal)num / (first - 64);
                    }
                    //LowerCase.
                    else
                    {
                        right += (decimal)num * (first - 96);
                    }


                    //UpperCase.
                    if (last >= 65 && last <= 90)
                    {
                        right-= (last - 64);
                    }
                    //LowerCase.
                    else
                    {
                        right+= (last - 96);
                    }
                }
                sum+=left+right;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
