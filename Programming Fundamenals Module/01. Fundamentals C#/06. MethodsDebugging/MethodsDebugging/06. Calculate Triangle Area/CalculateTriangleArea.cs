using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Triangle_Area
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width=double.Parse(Console.ReadLine());
            double height=double.Parse(Console.ReadLine());

            double calcArea=CalculateArea(width,height);

            Console.WriteLine(calcArea);
        }

        private static double CalculateArea(double width, double height)
        {
            return width*height/2;
        }
    }
}
