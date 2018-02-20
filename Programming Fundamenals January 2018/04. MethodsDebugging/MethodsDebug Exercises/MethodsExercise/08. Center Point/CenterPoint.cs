using System;

namespace _08._Center_Point
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            if (x1 + y1 >= x2 + y2)
            {
                Console.WriteLine($"{y2}, {x2}");
            }
            else
            {
                Console.WriteLine($"({y1}, {x1})");
            }
        }
    }
}
