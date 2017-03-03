using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double widght = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            var volume = (lenght * height * widght) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");



        }
    }
}
