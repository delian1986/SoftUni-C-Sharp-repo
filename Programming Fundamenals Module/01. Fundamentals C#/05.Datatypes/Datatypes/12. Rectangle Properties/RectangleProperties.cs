using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(2*a+2*b);
            Console.WriteLine(a*b);
            Console.WriteLine(Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2)));
        }
    }
}
