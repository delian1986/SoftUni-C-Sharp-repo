using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Andrey_And_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopingList = new SortedDictionary<string, decimal>();
            string[] input = new string[3];


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split('-').ToArray();
                if (!shopingList.ContainsKey(input[0]))
                {
                    shopingList.Add(input[0], decimal.Parse(input[1]));
                }
                else
                {
                    shopingList[input[0]] = decimal.Parse(input[1]);
                }
            }

            while (true)
            {
                if (input[0] == "end of clients")
                {
                    break;
                }

                input = Console.ReadLine().Split('-', ',');

                var client = new Customer
                {
                    Name = input[0],

                };
                if (!shopingList.ContainsKey(input[1]))
                {
                    continue;
                }
                if (!client.Orders.ContainsKey(input[1]))
                {
                    client.Orders.Add(input[1], int.Parse(input[2]));
                }
                else
                {
                    client.Orders[input[1]] += int.Parse(input[2]);
                }
            }


        }
    }


    public class Customer
    {
        public string Name { get; set; }
        public SortedDictionary<string, int> Orders { get; set; }
        public decimal Bill { get; set; }

    }
}
