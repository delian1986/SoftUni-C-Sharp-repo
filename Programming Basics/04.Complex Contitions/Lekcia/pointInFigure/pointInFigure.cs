using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointInFigure
{
    class pointInFigure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool inside = (x > 0 && x < 3 * h && y > 0 && y < h) ||
                (x > h && x < 2 * h && y > h && y < 4 * h)
                ;

            bool outside = (x > 3 * h && x < 0 && y > h && y < 0) ||
                (x < 0 && y < 0) ||
                (y > h && x < h) ||
                (x > 3 * h && y > 4 * h)||
                (x>h&&y<h)||
                (x>2*h&&y>h)||
                (x<h&&y<0)||
                (x>h&&y>4*h)||
                (x>2*h&&y>4*h)||
                (x>3*h&&y<h);
                
            var result = "";
            if (inside)
            {
                result = "inside";

            }
            else if (outside)
            {
                result = "outside";
            }
            Console.WriteLine(result);
        }
    }
}
