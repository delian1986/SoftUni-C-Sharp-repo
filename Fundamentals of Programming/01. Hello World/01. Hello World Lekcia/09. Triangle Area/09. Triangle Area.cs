using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = decimal.Parse(Console.ReadLine());
            var h = decimal.Parse(Console.ReadLine());

            var area = a * h / 2;
            Console.WriteLine(Math.Round(area,2));
        }
    }
}
