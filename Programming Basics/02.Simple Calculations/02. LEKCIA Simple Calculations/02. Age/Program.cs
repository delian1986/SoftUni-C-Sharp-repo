using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y2 = double.Parse(Console.ReadLine());
            double a = Math.Max(x1, x2) - Math.Min(x1,x2);
            double b = Math.Max(y1, y2) - Math.Min(y1, y2);
            double h = Math.Max(x1, y1) - Math.Min(x1, y1);
            double area = (a+b)*h/2;
            //double per = 2 * (a + b);
            Console.WriteLine("Area is: {0}",area);
            //Console.WriteLine("Perimeter is: {0}",per);
        }
    }
}
