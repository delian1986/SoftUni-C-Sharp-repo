using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housePaint
{
    class housePaint
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var greenLit = 0d;
            var redLit = 0d;

            ///wall
            var window = 2.25;
            var door = 2.40;

            var sideWall = x * y;
            var twoWalls = 2 * sideWall - 2 * window;
            var backWall = x * x;
            var twoBackWalls = 2 * backWall - door;
            var walls = twoWalls + twoBackWalls;
            greenLit = walls / 3.4;

            // roof
            var roofRect = 2 * (x * y);
            var twoTriangle = 2 * (x * h / 2);
            var totRoof = roofRect + twoTriangle;
            redLit = totRoof / 4.3;

            Console.WriteLine($"{greenLit:f2}\n{redLit:f2}");




        }
    }
}
