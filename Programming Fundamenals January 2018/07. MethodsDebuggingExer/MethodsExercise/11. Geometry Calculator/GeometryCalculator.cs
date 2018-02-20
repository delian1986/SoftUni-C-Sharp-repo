using System;

namespace _11._Geometry_Calculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area=0;

            if (figure=="triangle")
            {
                area=TriangleArea();
            }
            else if (figure=="square")
            {
                area=SquareArea();
            }
            else if (figure=="rectangle")
            {
                area=RectagleArea();
            }
            else if (figure=="circle")
            {
                area=CircleArea();
            }
            Console.WriteLine($"{area:f2}");
        }

        private static double CircleArea()
        {
            double radius=double.Parse(Console.ReadLine());
            return Math.PI*Math.Pow(radius,2);
        }

        private static double RectagleArea()
        {
            double sideA=double.Parse(Console.ReadLine());
            double sideB=double.Parse(Console.ReadLine());

            return sideA*sideB;
        }

        private static double SquareArea()
        {
            double sideA=double.Parse(Console.ReadLine());
            return Math.Pow(sideA,2);
        }

        private static double TriangleArea()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            return sideA*sideB/2;
        }
    }
}
