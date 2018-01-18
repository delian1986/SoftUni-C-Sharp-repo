using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AndreyAndBilliard
{
    static void Main(string[] args)
    {
        Dictionary<string, decimal> shopAvalableProducts = new Dictionary<string, decimal>();
        List<decimal> totalBill = new List<decimal>();
        List<Customer> clientsList = new List<Customer>();

        int incProducts = int.Parse(Console.ReadLine());
        for (int i = 0; i < incProducts; i++)
        {
            string[] tokens = Console.ReadLine().Split('-');

            string product = tokens[0];
            decimal productPrice = decimal.Parse(tokens[1]);

            if (!shopAvalableProducts.ContainsKey(product))
            {
                shopAvalableProducts.Add(product, productPrice);
            }
            else
            {
                shopAvalableProducts[product] = productPrice;
            }
        }

        while (true)
        {
            string clientQue = Console.ReadLine();
            if (clientQue == "end of clients")
            {
                break;
            }

            string[] tokents = clientQue.Split('-', ',');
            string user = tokents[0];
            string product = tokents[1];
            int quantity = int.Parse(tokents[2]);

            Customer newCust = new Customer();


            if (shopAvalableProducts.ContainsKey(product))
            {
                newCust.Name = user;
                newCust.Orders = new Dictionary<string, int>();
                newCust.Orders.Add(product, quantity);


                if (clientsList.Any(c => c.Name == user))
                {
                    Customer existingCust = clientsList.First(c => c.Name == user);
                    if (existingCust.Orders.ContainsKey(product))
                    {
                        existingCust.Orders[product] += quantity;
                    }
                    else
                    {
                        existingCust.Orders[product] = quantity;
                    }
                }
                else
                {
                    clientsList.Add(newCust);

                }

                foreach (var name in clientsList)
                {
                    foreach (var item in shopAvalableProducts)
                    {
                        if (item.Key == product&&name.Name==newCust.Name)
                        {
                            name.Bill += item.Value * quantity;
                            totalBill.Add(item.Value*quantity);
                        }
                    }

                }


            }


        }
        foreach (var name in clientsList.OrderBy(x => x.Name).ThenBy(x => x.Bill))
        {
            Console.WriteLine(name.Name);
            foreach (var item in name.Orders)
            {
                Console.WriteLine($"-- {item.Key} - {item.Value}");
            }
            Console.WriteLine($"Bill: {name.Bill:f2}");
        }
        Console.WriteLine($"Total bill: {totalBill.Sum():f2}");

    }

}


public class Customer
{
    public string Name { get; set; }
    public Dictionary<string, int> Orders { get; set; }
    public decimal Bill { get; set; }
    public decimal TotalBill { get; set; }
}
