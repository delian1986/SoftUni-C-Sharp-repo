using System;
using System.Text.RegularExpressions;

namespace _06._Replace_a_Tag
{
    class ReplaceTag
    {
        static void Main()
        {
            string url=string.Empty;
            string pattern=@"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement=@"[URL href=$1]$2[/URL]";

            while ((url=Console.ReadLine())!="end")
            {
                var replace=Regex.Replace(url,pattern,replacement);
                var isMatch=Regex.IsMatch(url,pattern);
                Console.WriteLine(replace);
            }
        }
    }
}
