using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleArea
{
    class triangleArea
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());



            var h = Math.Max(y1 , y3)-Math.Min(y1,y3);
            var a = Math.Max(x2 , x3)-Math.Min(x2,x3);


            Console.WriteLine((a * h) / 2);

        }
    }
}
