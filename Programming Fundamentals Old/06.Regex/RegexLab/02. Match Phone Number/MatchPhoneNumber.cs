using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/// <summary>
/// This regex expression matches phone numbers from Sofia. E.x. +359 2 222 2222, +359-2-222-2222
/// https://judge.softuni.bg/Contests/Practice/Index/452#1
/// </summary>

namespace _02._Match_Phone_Number
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string pattern=@"( ?\+359 2 \d{3} \d{4}\b)|( ?\+359-2-\d{3}-\d{4}\b)";
            string input=Console.ReadLine();
            List<string>phoneNums=new List<string>();

            foreach (Match num in Regex.Matches(input,pattern))
            {
                phoneNums.Add(num.Value.Trim());
                
            }

            Console.WriteLine(string.Join(", ",phoneNums));
        }
    }
}
