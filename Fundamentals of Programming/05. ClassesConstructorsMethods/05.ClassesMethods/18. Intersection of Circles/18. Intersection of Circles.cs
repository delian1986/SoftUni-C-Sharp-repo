using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] cirleOneInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] cirleTwoInput = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Point firstCenter = new Point(cirleOneInput[0], cirleTwoInput[1]);
            Point secondCenter = new Point(cirleTwoInput[0], cirleTwoInput[1]);

            Circle firstCircle = new Circle(firstCenter, cirleOneInput[2]);
            Circle secondCirle = new Circle(secondCenter, cirleTwoInput[2]);

            Console.WriteLine(Circle.IsIntersect(firstCircle, secondCirle));
        }
    }
}
class Circle
{
    public Point Center { get; set; }
    public double Radius { get; set; }

    public Circle(Point center, double radius)
    {
        Center = center;
        Radius = radius;
    }

    public static string IsIntersect(Circle c1, Circle c2)
    {
        double d = Point.CalculatePointDisct(c1.Center, c2.Center);
        if (d <= c1.Radius + c2.Radius)
        {
            return
             "Yes";

        }
        else if (d>c1.Radius+c2.Radius)
        {
            return "No";
        }
        else
        {
            return
            "No";

        }

    }

}
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(double x, double y)
    {
        X = (int)x;
        Y = (int)y;
    }

    public static double CalculatePointDisct(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
}
