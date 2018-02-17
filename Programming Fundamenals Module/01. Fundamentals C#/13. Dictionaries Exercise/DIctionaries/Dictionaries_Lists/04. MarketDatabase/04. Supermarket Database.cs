using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// This program collects products and calculate their prices 
/// uppon the given quanity.
/// https://judge.softuni.bg/Contests/Practice/Index/582#3
/// </summary>

namespace _04._MarketDatabase
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Here is the main container.
            List<Product>database=new List<Product>();

            string line=string.Empty;

            while ((line=Console.ReadLine())!="stocked")
            {
                string[]tokens=line.Split();
                string product=tokens[0];
                decimal price=decimal.Parse(tokens[1]);
                int quantity=int.Parse(tokens[2]);

                if (!database.Any(x=>x.Name==product))
                {
                    Product newProduct= new Product
                    {
                        Name=product,
                        Price=price,
                        Quantity=quantity
                    };
                    database.Add(newProduct);
                }
                else
                {
                    var currProduct=database.First(x=>x.Name==product);
                    currProduct.Price=price;
                    currProduct.Quantity+=quantity;
                }
            }

            decimal totalPriceOfAllProducts=0m;

            foreach (var product in database)
            {
                decimal price=product.Price*product.Quantity;
                Console.WriteLine($"{product.Name}: ${product.Price} * {product.Quantity} = ${(price):f2}");
                totalPriceOfAllProducts+=price;
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("-",30)));
            Console.WriteLine($"Grand Total: ${totalPriceOfAllProducts:f2}");
        }
    }
}
