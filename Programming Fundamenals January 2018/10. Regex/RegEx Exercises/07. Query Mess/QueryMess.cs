using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Compete/Index/430#6
/// </summary>

namespace _07._Query_Mess
{
    class Program
    {
        static void Main()
        {
            string text = string.Empty;
            //We match all exept separators.
            string pattern = @"([^=?&\n]+)=([^=?&\n]+)";


            while ((text = Console.ReadLine()) != "END")
            {
                //We reset this dictionary on every interation.
                Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();

                foreach (Match m in Regex.Matches(text, pattern))
                {
                    //Asstign groups.
                    string key = m.Groups[1].Value;
                    string value = m.Groups[2].Value;

                    //We replace all special symbols with space.
                    string replacePattern=@"(\+|%20)+";

                    key=Regex.Replace(key,replacePattern," ").Trim();
                    value=Regex.Replace(value,replacePattern," ").Trim();

                    if (!collection.ContainsKey(key))
                    {
                        collection.Add(key, new List<string>());
                    }
                    collection[key].Add(value);
                }

                //Printing the result.
                foreach (var key in collection)
                {
                    Console.Write($"{key.Key}=[{string.Join(", ", key.Value)}]");
                }
                Console.WriteLine();
            }

        }
    }
}
