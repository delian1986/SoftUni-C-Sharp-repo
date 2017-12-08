using System;

namespace _01.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());
            var widht = int.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var weight = double.Parse(Console.ReadLine());

            lenght = 2 * lenght + 2 * widht;
            price = lenght * price;
            var sq = lenght * height;
            weight = sq * weight;
            Console.WriteLine($"{lenght}");
            Console.WriteLine($"{price:f2}");
            Console.WriteLine($"{weight:f3}");

        }
    }
}
