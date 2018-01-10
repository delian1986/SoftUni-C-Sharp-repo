using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var minDist = double.MaxValue;
        List<Point> points = new List<Point>();
        List<Point> closestPoints = new List<Point>();

        for (int i = 0; i < n; i++)
        {
            var coords = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point p = new Point
            {
                X = coords[0],
                Y = coords[1],


            };
            points.Add(p);
        }

        for (var i = 0; i < points.Count; i++)
        {
            for (var j = i + 1; j < points.Count; j++)
            {

                var dist = DistanceBetweenPoints(points[i], points[j]);
                if (dist < minDist)
                {
                    minDist = dist;
                    closestPoints.Insert(0, points[j]);
                    closestPoints.Insert(0, points[i]);
                }
            }
        }
        var res = closestPoints.Take(2);
        Console.WriteLine($"{minDist:f3}");
        foreach (var item in res)
        {

            Console.Write("(" + item.X + "," + " ");
            Console.WriteLine(item.Y + ")");

        }
    }

    private static double DistanceBetweenPoints(Point point1, Point point2)
    {
        return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));

    }
}
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

}

