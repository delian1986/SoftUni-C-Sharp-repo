using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var coords = new Point
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

}

