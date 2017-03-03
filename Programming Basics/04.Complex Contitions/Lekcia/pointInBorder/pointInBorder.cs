using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointInBorder
{
    class pointInBorder
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            var leftSideBorder = (x == x1 && y >= y1 && y <= y2);
            var rightSideBorder = (x == x2 && y >= y1 && y <= y2);
            var upSideBorder = (y == y1 && x >= x1 && x <= x2);
            var downSideBorder = (y == y2 && x >= x1 && x <= x2);

            if (leftSideBorder||rightSideBorder||upSideBorder||downSideBorder)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
