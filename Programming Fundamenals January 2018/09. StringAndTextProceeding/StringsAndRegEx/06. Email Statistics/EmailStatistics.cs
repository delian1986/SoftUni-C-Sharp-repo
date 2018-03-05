using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/585#5
/// </summary>

namespace _06._Email_Statistics
{
    class EmailStatistics
    {
        static void Main()
        {
            int numOfLines=int.Parse(Console.ReadLine());
            string addressPattern=@"^([A-Za-z]{5,})@([a-z]{3,}.(com|bg|org))$";

            Dictionary<string,HashSet<string>>emailBook=new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < numOfLines; i++)
            {
                string text= Console.ReadLine();

                foreach (Match line in Regex.Matches(text,addressPattern))
                {
                    var username=line.Groups[1].Value;
                    var domain=line.Groups[2].Value;

                    if (!emailBook.ContainsKey(domain))
                    {
                        emailBook.Add(domain,new HashSet<string>());
                    }
                    emailBook[domain].Add(username);
                }
            }
            
            var ordered=emailBook.OrderByDescending(x=>x.Value.Count);

            foreach (var domain in ordered)
            {
                Console.WriteLine($"{domain.Key}:");
                
                foreach (var user in domain.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
                
        }
    }
}
