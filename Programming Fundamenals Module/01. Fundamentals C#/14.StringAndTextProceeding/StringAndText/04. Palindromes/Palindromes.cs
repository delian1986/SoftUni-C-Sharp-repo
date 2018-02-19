using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// This program check for palidromes in sequence of words,
/// adds only unique of them in list, them prient them ordered.
/// https://judge.softuni.bg/Contests/Practice/Index/320#3
/// </summary>

namespace _04._Palindromes
{
    class Program
    {
        private static int list;

        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palidromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (Enumerable.SequenceEqual(words[i].ToCharArray(), words[i].ToCharArray().Reverse()))
                {
                    if (!palidromes.Contains(words[i]))
                    {
                        palidromes.Add(words[i]);
                    }
                }
            }

            palidromes.Sort();
            Console.WriteLine(string.Join(", ", palidromes));
        }
    }
}
