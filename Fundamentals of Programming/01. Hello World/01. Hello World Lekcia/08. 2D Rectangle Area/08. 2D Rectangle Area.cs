using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            var x = Math.Abs(x1 - x2);
            var y = Math.Abs(y1 - y2);

            var area = x * y;
            var per = 2 * (x + y);
            Console.WriteLine($"{area}");
            Console.WriteLine($"{per}");
        }
    }
}
