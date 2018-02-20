using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// This program checks if who string are exchangebles (?).
/// https://judge.softuni.bg/Contests/Compete/Index/321#4
/// </summary>

namespace _05._Magic_exchangeable_words
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split();
            Dictionary<char, char> chars = new Dictionary<char, char>();

            string wordOne = inputLine[0];
            string wordTwo = inputLine[1];

            int first=wordOne.Distinct().Count();
            int second=wordTwo.Distinct().Count();

            if (first==second)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
