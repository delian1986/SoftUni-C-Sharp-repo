using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Logs_Aggregator
{

    class LogsAggregator
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string,SortedDictionary<string,int>> dict= new Dictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split();
                string ip = input[0];
                string name = input[1];
                int session = int.Parse(input[2]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new SortedDictionary<string, int>());
                }
                if (!dict[name].ContainsKey(ip))
                {
                    dict[name].Add(ip, 0);
                }
                dict[name][ip] += session;
            }

            foreach (var user in dict.OrderBy(x=>x.Key))
            {
                var sum = user.Value.Values.Sum();

                Console.WriteLine($"{user.Key}: {sum} [{string.Join(", ",user.Value.Keys)}]");
            }
        }
    }
}
