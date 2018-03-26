using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/919#2
/// </summary>

namespace _03._Friends_from_Rainy_Universe
{
    class Program
    {
        static void Main()
        {
            string inputLine = string.Empty;

            Dictionary<string, Dictionary<string, long>> friends = new Dictionary<string, Dictionary<string, long>>();

            while ((inputLine=Console.ReadLine())!="End")
            {
                //Spliting input.
                string[] args = inputLine.Split(new[] { '-', '>',':',' '},StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];
                string liquid = args[1];
                long count = long.Parse(args[2]);

                //Populating dictionaries.
                if (!friends.ContainsKey(name))
                {
                    friends.Add(name, new Dictionary<string, long>());
                }
                if (!friends[name].ContainsKey(liquid))
                {
                    friends[name].Add(liquid, 0);
                }

                friends[name][liquid] += count;
            }

            //Sorting by conditions.
            var sorted = friends.OrderBy(x => x.Key).ThenBy(x => x.Value.Count);

            foreach (var name in sorted)
            {
                Console.WriteLine($"{name.Key} Liquids:");

                foreach (var count in name.Value.OrderBy(x=>x.Value))
                {
                    Console.WriteLine($"--- {count.Key}: {count.Value}");
                }
            }
        }
    }
}
