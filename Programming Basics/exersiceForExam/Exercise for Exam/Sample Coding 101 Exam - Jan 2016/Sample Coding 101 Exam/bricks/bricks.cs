using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bricks
{
    class bricks
    {
        static void Main(string[] args)
        {
            var numBricks = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var carts = double.Parse(Console.ReadLine());

            var bricksByCourse = workers * carts;
            var result = Math.Ceiling( numBricks / bricksByCourse);
            Console.WriteLine(result);
        }
    }
}
