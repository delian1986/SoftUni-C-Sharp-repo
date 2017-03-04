using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var Area = Math.PI * r * r;
            var Perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area = " + Area);
            Console.WriteLine("Perimeter = " + Perimeter);
        }
    }
}
