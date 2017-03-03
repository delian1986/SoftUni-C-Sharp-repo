using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._2d_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1= double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a = Math.Max(x1,x2) - Math.Min(x1,x2);
            double b = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine(a *b);
            Console.WriteLine(2*(a +b));
        }
    }
}
