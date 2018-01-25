using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {product}:");
            Console.WriteLine($"{(double)(volume*energy)/100}kcal, {(double)(sugar*volume)/100}g sugars");
        }
    }
}
