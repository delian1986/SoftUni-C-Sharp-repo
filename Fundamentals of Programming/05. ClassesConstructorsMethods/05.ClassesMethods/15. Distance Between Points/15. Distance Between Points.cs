using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstPointInput = Console.ReadLine().Split();
            var firstPoint = new Point
            {
                X = double.Parse(firstPointInput[0]),
                Y= double.Parse(firstPointInput[1])
            };

            string[] secPointInput = Console.ReadLine().Split();

            var secPoint = new Point
            {
                X = double.Parse(secPointInput[0]),
                Y = double.Parse(secPointInput[1])

            };

            var dist = CalcDist(firstPoint, secPoint);
            Console.WriteLine($"{dist:f3}");
        }

        static object CalcDist(Point firstPoint, Point secPoint)
        {
            var sideA = Math.Abs(firstPoint.X - secPoint.X);
            var sideB = Math.Abs(firstPoint.Y - secPoint.Y);
            var c = Math.Sqrt(sideA * sideA + sideB * sideB);
            return c;
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
