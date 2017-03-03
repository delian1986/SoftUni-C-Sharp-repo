using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool valid = a + b > c && b + c > a && a + c > b;
            if (valid == false)
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }

            if (valid)
            {
                Console.WriteLine("Triangle is valid.");

            }
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (Math.Pow(c, 2) + Math.Pow(a, 2) == Math.Pow(b, 2))
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else
            {
                Console.WriteLine("Triangle has no right angles");
            }

            
            
                
            
        }
    }
}
