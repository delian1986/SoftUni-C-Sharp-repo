using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLog = new SortedDictionary<string, Dictionary<string, int>>();
            //Dictionary<string, int> chatInput = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input!="end")
            {
                var text = input.Split(new string[] { "=", " " },StringSplitOptions.RemoveEmptyEntries);
                string ip = text[1];
               string user=text[5];

                var counter = 0;
                
                


                if (!userLog.ContainsKey(user))
                {

                    userLog[user] = new Dictionary<string, int>();
                }

                if (!userLog[user].ContainsKey(ip))
                {
                    userLog[user][ip] = 0;
                    counter = 1;
                }

                userLog[user][ip] += counter;

                input = Console.ReadLine();

            }

            foreach (var item in userLog)
            {
                var name = item.Key;
                Console.WriteLine($"{name}:");
                var ip = item.Value;
                foreach (var itemmm in ip)
                {
                Console.WriteLine($"{itemmm.Key} => {itemmm.Value}");

                }
            }

        }
    }
}
