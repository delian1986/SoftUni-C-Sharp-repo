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
            List<Customer> custList = new List<Customer>();

            var total = new Customer();

            int n = int.Parse(Console.ReadLine());
            input = ShopingList(shopingList, input, n);

            while (true)
            {
                input = Console.ReadLine().Split('-', ',');

                if (input[0] == "end of clients")
                {
                    break;
                }

                if (!shopingList.ContainsKey(input[1]))
                {
                    continue;
                }

                Customer client = new Customer();
                var clientName = input[0];
                var product = input[1];
                var quantity = int.Parse(input[2]);


                client.Name = clientName;
                client.Orders = new SortedDictionary<string, int>();

                if (!client.Orders.ContainsKey(product))
                {
                    client.Orders.Add(product, quantity);
                }
                else
                {
                    client.Orders[product] += quantity;
                }
                custList.Add(client);

                if (custList.Any(x => x.Name == client.Name))
                {
                    var cust = custList.Where(x => x.Name == client.Name).First();

                    if (cust.Orders.ContainsKey(product))
                    {
                        cust.Orders[product] += quantity;
                    }
                    else
                    {
                        cust.Orders.Add(product, quantity);
                    }
                }
                client.Bill += shopingList[product] * quantity;

                total.TotalBill += client.Bill;
            }

            foreach (var c in custList.OrderBy(x => x.Name))
            {
                Console.WriteLine(c.Name);
                foreach (var item in c.Orders)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                    Console.WriteLine($"Bill: {c.Bill:f2}");
                }
            }
            Console.WriteLine($"Total bill: {total.TotalBill:f2}");


        }

        private static string[] ShopingList(SortedDictionary<string, decimal> shopingList, string[] input, int n)
        {
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

            return input;
        }
    }


    public class Customer
    {
        public string Name { get; set; }
        public SortedDictionary<string, int> Orders { get; set; }
        public decimal Bill { get; set; }
        public decimal TotalBill { get; set; }
    }
}
