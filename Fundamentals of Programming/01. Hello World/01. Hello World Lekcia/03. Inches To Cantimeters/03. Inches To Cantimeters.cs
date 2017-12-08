using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Inches_To_Cantimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inch = double.Parse(Console.ReadLine());

            var cent = inch * 2.54;

            Console.WriteLine(cent);
        }
    }
}
