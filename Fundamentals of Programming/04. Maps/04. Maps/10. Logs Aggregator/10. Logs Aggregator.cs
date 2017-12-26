using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> dictionary = new SortedDictionary<string, SortedDictionary<string, int>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string ip = input[0];
                string user = input[1];
                int time = int.Parse(input[2]);



                if (!dictionary.ContainsKey(user))
                {
                    dictionary.Add(user, new SortedDictionary<string, int>());
                }

                if (!dictionary[user].ContainsKey(ip))
                {
                    dictionary[user].Add(ip, time);
                }
                else
                {
                    dictionary[user][ip] += time;
                }


            }

            foreach (var person in dictionary)
            {
                var sum = person.Value.Values.Sum();
                Console.Write(person.Key+$": {sum} ");
                    Console.Write("[");

                Console.Write(string.Join(", ", person.Value.Keys));
                Console.Write("]");
                Console.WriteLine();
            }
            

        }
    }
}
