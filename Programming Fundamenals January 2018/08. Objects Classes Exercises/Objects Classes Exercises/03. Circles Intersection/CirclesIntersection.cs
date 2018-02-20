using System;
using System.Linq;


/// <summary>
/// This program compares two circles in 2D coordinate system and establishes if they have common point.
/// https://judge.softuni.bg/Contests/Compete/Index/210#2
/// </summary>
namespace _03._Circles_Intersection
{
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public bool IsIntersected(Circle cirle)
        {
            double distance = Math.Sqrt(Math.Abs(cirle.Center.X - Center.X)*Math.Abs(cirle.Center.X - Center.X) + Math.Abs(cirle.Center.Y - Center.Y)*Math.Abs(cirle.Center.Y - Center.Y));


            if (distance<=cirle.Radius+Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

    }
    class CirclesIntersection
    {
        static void Main()
        {
            //First Circle coordinates X,Y of the center and radius.
            double[] points = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle circle1=new Circle();
            circle1.Center=new Point();
            circle1.Center.X=points[0];
            circle1.Center.Y=points[1];
            circle1.Radius=points[2];

            //Second Circle coordinates X,Y of the center and radius.
            double[] points2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle circle2=new Circle();
            circle2.Center=new Point();
            circle2.Center.X=points2[0];
            circle2.Center.Y=points2[1];
            circle2.Radius=points2[2];

            if (circle1.IsIntersected(circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
