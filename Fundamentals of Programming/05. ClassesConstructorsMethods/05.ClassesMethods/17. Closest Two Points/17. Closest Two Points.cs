using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split();
            var coords = new point
            {
                X = int.Parse(input[0]),
                Y = int.Parse(input[1])
            };


        }
    }
}
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x,int y)
    {
        X = x;
        Y = y;

    }
    public double ClosestPoint(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
}

