using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Circle_Perimeter__12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());

            var res = 2 * Math.PI * r;
            Console.WriteLine($"{res:f12}");


        }
    }
}
