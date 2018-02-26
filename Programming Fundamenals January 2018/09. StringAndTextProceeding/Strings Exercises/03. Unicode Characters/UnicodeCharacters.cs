using System;

/// <summary>
/// This program convert chars to unicode chars.
/// https://judge.softuni.bg/Contests/Compete/Index/321#2
/// </summary>

namespace _03._Unicode_Characters
{
    class UnicodeChars
    {
        static void Main()
        {
            string inputLine=Console.ReadLine();

            foreach (var symbol in inputLine)
            {
                Console.Write("\\u{0:x4}",(int)symbol);
            }

            
        }
    }
}
