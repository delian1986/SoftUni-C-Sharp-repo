using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = decimal.Parse(Console.ReadLine());

            var area = (decimal)Math.PI * r * r;
            var per = 2 * (decimal) Math.PI * r;

            Console.WriteLine($"{area:f4}" );
            Console.WriteLine($"{per:f4}");

        }
    }
}
