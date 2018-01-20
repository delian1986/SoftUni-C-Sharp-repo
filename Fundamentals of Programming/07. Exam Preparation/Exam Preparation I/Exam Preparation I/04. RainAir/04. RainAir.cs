using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> customersDic = new Dictionary<string, List<int>>();

            string inputLine = string.Empty;


            while ((true))
            {
                inputLine = Console.ReadLine();

                if (inputLine == "I believe I can fly!")
                {
                    break;
                }

                if (inputLine.Contains('='))
                {
                    customersDic= MakeUsersEqual(customersDic, inputLine);
                }
                else
                {
                    customersDic=AddingElements(customersDic, inputLine);
                }
            }

            var sorted = customersDic.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var user in sorted)
            {
                Console.WriteLine($"#{user.Key} ::: {(string.Join(", ",user.Value.OrderBy(x=>x)))}");
            }
        }

        private static Dictionary<string, List<int>> AddingElements(Dictionary<string, List<int>> customersDic, string inputLine)
        {
            string[] tokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string user = tokens[0];

            if (!customersDic.ContainsKey(user))
            {
                customersDic.Add(user, new List<int>());

            }
            for (int i = 1; i < tokens.Length; i++)
            {
                customersDic[user].Add(int.Parse(tokens[i]));
            }

            return customersDic;
        }

        private static Dictionary<string, List<int>> MakeUsersEqual(Dictionary<string, List<int>> customersDic, string inputLine)
        {
            string[] tokens = inputLine.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

            string user = tokens[0].Trim();
            string user2 = tokens[1].Trim();


            customersDic[user] = new List<int>(customersDic[user2]);

            return customersDic;
        }
    }
}
