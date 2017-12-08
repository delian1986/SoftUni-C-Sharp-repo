using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Point_on_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            var result = String.Empty;

            var leftSide = x ==x1 && y >= y1 && y <= y2;
            var upSide = x >= x1 && x <= x2 && y == y1;
            var botSide = x >= x1 && x <= x2 && y == y2;
            var rightSide = x == x2 && y >= y1 && y <= y2;

            if (leftSide||upSide||botSide||rightSide)
            {
                result = "Border";

            }
            else
            {
                result = "Inside / Outside";
            }
            Console.WriteLine(result);
        }
    }
}
