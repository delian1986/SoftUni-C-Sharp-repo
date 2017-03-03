using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.vegetable_market
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal vegPrice = decimal.Parse(Console.ReadLine());
            decimal fruPrice = decimal.Parse(Console.ReadLine());
            var vegValue = int.Parse(Console.ReadLine());
            var fruValue = int.Parse(Console.ReadLine());
            var vegTotal = vegPrice * vegValue;
            var fruTotal = fruPrice * fruValue;
            var profit = vegTotal + fruTotal;
            var euroProfit = profit / 1.94M;
            Console.WriteLine(euroProfit);
        }
    }
}
