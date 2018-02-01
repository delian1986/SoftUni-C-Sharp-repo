using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int sizeOfFigure = int.Parse(Console.ReadLine());

            PrintDashes(sizeOfFigure);
            PrintBody(sizeOfFigure);
            PrintDashes(sizeOfFigure);

        }

        private static void PrintBody(int sizeOfFigure)
        {
            Console.Write("-");
            for (int i = 1; i < sizeOfFigure; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        private static void PrintOneDash()
        {
            Console.Write("-");
        }

        private static void PrintDashes(int sizeOfFigure)
        {
            Console.WriteLine(new string('-', sizeOfFigure * 2));
        }
    }
}
