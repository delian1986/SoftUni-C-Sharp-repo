using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class MatchPhoneNums
    {
        static void Main()
        {
            string text= Console.ReadLine();
            string pattern=@"\+359 2 [\d]{3} [\d]{4}\b|\+359-[\d]{1}-[\d]{3}-[\d]{4}\b";

            List<string> result=new List<string>();

            foreach (Match num in Regex.Matches(text,pattern))
            {
                result.Add(num.Value);
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
