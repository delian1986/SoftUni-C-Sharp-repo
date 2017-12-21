using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area=CalculateTriangleArea(a, b);

            Console.WriteLine(area);
        }

        private static double CalculateTriangleArea(double a, double b)
        {
            return a * b / 2;
        }
    }
}
