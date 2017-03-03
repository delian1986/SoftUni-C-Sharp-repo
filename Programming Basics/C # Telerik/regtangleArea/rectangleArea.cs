using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regtangleArea
{
    class rectangleArea
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var res =( a * b);
            var per = (2 *a)+(2 * b);
            Console.WriteLine("{0:F2} {1:F2}",res,per);
        }
    }
}
