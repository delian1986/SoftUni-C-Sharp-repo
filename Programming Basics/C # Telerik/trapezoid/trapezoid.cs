using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trapezoid
{
    class trapezoid
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var res = (((a+b)/2)*h);
            Console.WriteLine("{0:f7}" ,res);
        }
    }
}
