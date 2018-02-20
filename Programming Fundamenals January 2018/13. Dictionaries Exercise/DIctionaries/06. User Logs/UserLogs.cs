using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._User_Logs
{
    class Program
    {
        static void Main()
        {
            string input = string.Empty;

            Dictionary<string, Dictionary<string, int>> userLogs = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] args = input.Split(new[] { '=', ' ' });
                string ip = args[1];
                string user = args[5];

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                }
                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user].Add(ip, 0);
                }
                userLogs[user][ip]++;

            }


            foreach (var user in userLogs.OrderBy(x => x.Key))
            {
                int count = 1;
                Console.WriteLine($"{user.Key}:");
                foreach (var ip in user.Value)
                {
                    var nums = user.Value.Count;
                    string symb = String.Empty;
                    if (count < nums)
                    {
                        symb = ", ";
                        count++;
                    }
                    else
                    {
                        symb = ".";
                    }
                    Console.Write($"{ip.Key} => {ip.Value}{symb}");
                }
                Console.WriteLine();
            }
        }

    }
}
