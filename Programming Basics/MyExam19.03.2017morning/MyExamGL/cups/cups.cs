using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cups
{
    class cups
    {
        static void Main(string[] args)
        {
            var cups = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());

            var production = days * 8 * workers;
            var totProduct = Math.Floor(production / 5d);

            if (cups>totProduct)
            {
                var res = cups - totProduct;
                var loses = res * 4.2;
                Console.WriteLine($"Losses: {loses:f2}");
            }
            else if (cups<=totProduct)
            {
                var res = totProduct - cups;
                var extra = res * 4.2;
                Console.WriteLine($"{extra:f2} extra money");
            }
        }
    }
}
