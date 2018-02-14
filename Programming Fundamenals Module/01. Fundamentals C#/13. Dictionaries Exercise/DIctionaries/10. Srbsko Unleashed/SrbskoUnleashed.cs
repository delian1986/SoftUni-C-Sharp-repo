using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10._Srbsko_Unleashed
{
    class SrbskoUnleashed
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> srbsko = new Dictionary<string, Dictionary<string, long>>();

            string pattern= @"(?<name>([a-zA-Z]+\s?){1,3}) @(?<venue>([A-Za-z]+\s?){1,3}) (?<price>\d+) (?<count>\d+)";
            var regex=new Regex(pattern);

            string input = string.Empty;

            
            while ((input = Console.ReadLine()) != "End")
            {
                if (!regex.IsMatch(input))
                {
                    continue;
                }
                else
                {
                    Match match = regex.Match(input);

                    string artist=match.Groups["name"].Value;
                    string venue=match.Groups["venue"].Value;
                    long ticketPrice= long.Parse(match.Groups["price"].Value);
                    long count= long.Parse(match.Groups["count"].Value);

                    if (!srbsko.ContainsKey(venue))
                    {
                        srbsko.Add(venue, new Dictionary<string, long>());
                    }
                    if (!srbsko[venue].ContainsKey(artist))
                    {
                        srbsko[venue].Add(artist,0);
                    }
                    srbsko[venue][artist]+=(ticketPrice*count);

                }
            }

            foreach (var venue in srbsko)
            {
                Console.WriteLine($"{venue.Key}");
                foreach (var singer in venue.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
