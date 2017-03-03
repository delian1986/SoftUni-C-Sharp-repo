using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairOfTile
{
    class RepairOfPlates
    {
        static void Main(string[] args)
        {
            var plazaLenght = double.Parse(Console.ReadLine());
            var plateLenght = double.Parse(Console.ReadLine());
            var plateWidth = double.Parse(Console.ReadLine());
            var benchWidth = double.Parse(Console.ReadLine());
            var benchLenght = double.Parse(Console.ReadLine());

            var plazaArea = plazaLenght * plazaLenght;
            var benchArea = benchLenght * benchWidth;
            var areaToCover = plazaArea - benchArea;
            var plareArea = plateLenght * plateWidth;
            var neededPlates = areaToCover / plareArea;
            var neededTime = neededPlates * 0.2;
            Console.WriteLine(neededPlates);
            Console.WriteLine(neededTime);



        }
    }
}
