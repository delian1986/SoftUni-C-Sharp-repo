using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Upgraded_Matcher
{
    public class Product
    {
        public string Name { get; set; }
        public long Quantity { get; set; }
        public decimal Price { get; set; }
    }

    class UpgradedMatcher
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<long> numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            decimal[] prices = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            if (numbers.Count < items.Length)
            {
                int itemsToAdd = items.Length - numbers.Count;
                for (int i = 0; i < itemsToAdd; i++)
                {
                    numbers.Add(0);
                }
            }

            List<Product> store = new List<Product>();

            for (int i = 0; i < items.Length; i++)
            {
                Product product = new Product
                {
                    Name = items[i],
                    Quantity = numbers[i],
                    Price = prices[i]
                };

                store.Add(product);
            }

            string inputLine = string.Empty;
            while ((inputLine = Console.ReadLine()) != "done")
            {
                string[] order = inputLine.Split();
                string stuff = order[0];
                long quantity = long.Parse(order[1]);

                foreach (var item in store)
                {
                    if (item.Name == stuff)
                    {
                        if (quantity <= item.Quantity)
                        {
                            Console.WriteLine($"{item.Name} x {quantity} costs {(item.Price * quantity):f2}");
                            item.Quantity -= quantity;
                        }
                        else
                        {
                            Console.WriteLine($"We do not have enough {item.Name}");
                        }
                    }
                }
            }
        }
    }
}
