using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            decimal percent = decimal.Parse(Console.ReadLine());

            decimal volume = lenght * width * height;
            decimal liter = volume * 0.001m;
            percent = percent * 0.01m;
            decimal result = liter * (1 - percent);
            Console.WriteLine($"{result:f3}");


        }
    }
}
