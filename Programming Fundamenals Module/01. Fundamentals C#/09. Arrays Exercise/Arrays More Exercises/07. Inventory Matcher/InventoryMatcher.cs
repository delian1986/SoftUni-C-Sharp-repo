using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Inventory_Matcher
{
    public class Product
    {
        public string Name { get; set; }
        public long Quantity { get; set; }
        public decimal Price { get; set; }
    }
    class InventoryMatcher
    {
        static void Main()
        {
            string[] items = Console.ReadLine().Split(new[]{' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            long[] numbers = Console.ReadLine().Split(new[]{' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(new[]{' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

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

                foreach (var item in store)
                {
                    if (inputLine == item.Name)
                    {
                        Console.WriteLine($"{item.Name} costs: {item.Price}; Available quantity: {item.Quantity}");

                    }
                }

            }
        }
    }
}
