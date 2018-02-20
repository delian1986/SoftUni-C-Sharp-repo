using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Make a shopping program. When a customer wish to buy something the program should check if the product exist in the shop first. After that the program make a bill for every single customer and sum the whole bill.
/// https://judge.softuni.bg/Contests/Compete/Index/210#6
/// </summary>
namespace _07._Andrey_and_Billiard
{
    class Shop
    {
        // Here the program stores the products.
        public Dictionary<string, decimal> ShopProducts { get; set; }
    }

    class Customer
    {
        //This is the shoping list where the program store the bought products.
        public Dictionary<string, int> WishList { get; set; }
        
        public string Name { get; set; }
        
        //Here the program stores the bill for every customer.
        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Here the program stores the products.
            Shop shop = new Shop();
            shop.ShopProducts = new Dictionary<string, decimal>();

            //How many products the shop will have.
            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string product = input[0];
                decimal price = decimal.Parse(input[1]);

                if (!shop.ShopProducts.ContainsKey(product))
                {
                    shop.ShopProducts.Add(product, 0);
                }
                shop.ShopProducts[product] = price;
            }

            //This is the main list where the program stores all customers.
            string line = String.Empty;
            List<Customer> allCust = new List<Customer>();

            while ((line = Console.ReadLine()) != "end of clients")
            {
                //input of clients.
                string[] tokens = line.Split(new char[] { '-', ',' });

                string clientName = tokens[0];
                string product = tokens[1];
                int quantity = int.Parse(tokens[2]);

                //If there is invalid product.
                if (!shop.ShopProducts.ContainsKey(product))
                {
                    continue;
                }

                //The price of current product.
                decimal price = shop.ShopProducts[product];


                Customer newCust = new Customer();
                newCust.WishList = new Dictionary<string, int>();
                newCust.WishList.Add(product, quantity);
                newCust.Name=clientName;
                newCust.Bill=price*quantity;

                //If the customer is back for another purchase.
                if (allCust.Any(x => x.Name == clientName))
                {
                    var currCust = allCust.Find(x => x.Name == clientName);
                    if (currCust.WishList.ContainsKey(product))
                    {
                        currCust.WishList[product] += quantity;
                        currCust.Bill += newCust.Bill;
                    }
                    else
                    {
                        currCust.WishList.Add(product,quantity);
                        currCust.Bill += newCust.Bill;
                    }
                }
                else
                {
                    //Populating the main list.
                    allCust.Add(newCust);
                }

            }
            //Total bill for all customers.
            decimal total=0;

            foreach (var person in allCust.OrderBy(x=>x.Name))
            {
                Console.WriteLine(person.Name);
                foreach (var products in person.WishList)
                {
                    Console.WriteLine($"-- {products.Key} - {products.Value}");
                }
                Console.WriteLine($"Bill: {person.Bill:f2}");
                total+=person.Bill;
            }
            Console.WriteLine($"Total bill: {total:f2}");
        }
    }
}
