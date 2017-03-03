using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hungryGarfield
{
    class hunglryGargield
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var rate = decimal.Parse(Console.ReadLine());

            var pizzaPrice = decimal.Parse(Console.ReadLine());
            var lasagnaPrice = decimal.Parse(Console.ReadLine());
            var sandwichPrice = decimal.Parse(Console.ReadLine());

            var pizzaQuantity = uint.Parse(Console.ReadLine());
            var lasagnaQuantity = uint.Parse(Console.ReadLine());
            var sandwichQuantit = uint.Parse(Console.ReadLine());

            var cost = ((pizzaPrice / rate) * pizzaQuantity) + ((lasagnaPrice / rate) * lasagnaQuantity) + ((sandwichPrice / rate) * sandwichQuantit);

            if (cost <= money)
            {
                var res = (money - cost);
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", res);
            }
            else
            {
                var res = cost - money;
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", res);
            }


        }
    }
}
