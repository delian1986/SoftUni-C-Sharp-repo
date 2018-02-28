using System;
using System.Text.RegularExpressions;

namespace _05._Only_Letters
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"([\d]+)([A-Za-z])";
            Regex reg= new Regex(pattern);

            MatchCollection replace= reg.Matches(text);

            foreach (Match item in replace)
            {
                text= Regex.Replace(text,item.Groups[1].Value.ToString(),item.Groups[2].Value.ToString());
            }
            Console.WriteLine(text);
        }
    }
}
