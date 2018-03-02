using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._RegeQuit
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToUpper();
            string pattern = @"(\D+)(\d+)";
            List<char> unique = new List<char>();

            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(text);
            StringBuilder res= new StringBuilder();

            foreach (Match item in matches)
            {
                string letter = item.Groups[1].Value;
                int count = int.Parse(item.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    res.Append(letter);
                }

                if (count > 0)
                {
                    unique.AddRange(letter);

                }
            }

            Console.WriteLine($"Unique symbols used: {unique.Distinct().Count()}");
            Console.WriteLine(res);
        }
    }
}
