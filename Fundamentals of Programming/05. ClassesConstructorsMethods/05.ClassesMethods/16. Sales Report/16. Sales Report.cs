using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            SortedDictionary<string, decimal> mySales = new SortedDictionary<string, decimal>();



            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().ToList();

                var sale = new Sale
                {
                    Town = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = decimal.Parse(input[3])

                };

                if (!mySales.ContainsKey(sale.Town))
                {
                    mySales.Add(sale.Town, sale.SetSale);
                }
                else
                {
                    mySales[sale.Town] += sale.SetSale;
                }

            }


            foreach (var item in mySales)
            {
                Console.Write(item.Key);
                Console.Write(" -> ");
                Console.WriteLine($"{item.Value:f2}");
            }

        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal SetSale => Price * Quantity;
    }
}
