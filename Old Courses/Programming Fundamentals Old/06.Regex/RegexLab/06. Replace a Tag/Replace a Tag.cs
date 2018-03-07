using System;
using System.Text.RegularExpressions;

/// <summary>
/// This program replace html anchor tag with URL.
/// </summary>

namespace _06._Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input=String.Empty;
            string pattern=@"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement=@"[URL href=$1]$2[/URL]";

            while ((input=Console.ReadLine())!="end")
            {
                string replaced= Regex.Replace(input,pattern,replacement);

                Console.WriteLine(replaced);
            }


        }
    }
}
