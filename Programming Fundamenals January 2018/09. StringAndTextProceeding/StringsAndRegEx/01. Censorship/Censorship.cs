using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01._Censorship
{
    class Censorship
    {
        static void Main()
        {
            //string pattern = $@"{Console.ReadLine()}";
            string pattern = Console.ReadLine();

            string text = Console.ReadLine();
            string replacement = string.Concat(Enumerable.Repeat("*", pattern.Length));

            int position=0;

            while (true)
            {
                if (position+pattern.Length>text.Length)
                {
                    break;
                }
                string checker=text.Substring(position,pattern.Length);
                if (checker==pattern)
                {
                    text=text.Replace(checker,replacement);
                }
                position++;
            }
            //text = Regex.Replace(text, pattern, replacement);
            Console.WriteLine(text);

        }
    }
}
