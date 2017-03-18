using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal vegPrice = decimal.Parse(Console.ReadLine());
            decimal fruPrice = decimal.Parse(Console.ReadLine());
            var totalKgVeg = int.Parse(Console.ReadLine());
            var totalKgFru = int.Parse(Console.ReadLine());

            var vegCost = totalKgVeg * vegPrice;
            var fruCost = totalKgFru * fruPrice;
            var total = (vegCost + fruCost) / 1.94m;
            Console.WriteLine(total);
        }
    }
}
