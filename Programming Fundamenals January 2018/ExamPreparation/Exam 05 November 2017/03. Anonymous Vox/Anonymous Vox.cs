using System;
using System.Text.RegularExpressions;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/835#0
/// </summary>

namespace _03._Anonymous_Vox
{
    class AnonymousVox
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] replacement = Console.ReadLine().Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern=@"([a-zA-Z]+)(.+)(\1)";
            var matches= Regex.Matches(text,pattern);

            int indexOfReplacement = 0;

            foreach (Match item in matches)
            {
               string decoded=item.Groups[1]+replacement[indexOfReplacement++]+item.Groups[3];
                text=text.Replace(item.Value,decoded);

            }

            Console.WriteLine(text);
        }
    }
}
