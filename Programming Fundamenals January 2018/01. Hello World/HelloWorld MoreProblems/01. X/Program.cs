using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int figSize = int.Parse(Console.ReadLine());
            int outerBlank = 0;
            int innerBlank = figSize - 2;
            PrintUpperPart(figSize, ref outerBlank, ref innerBlank);
            PrintBottomPart(figSize,outerBlank,innerBlank);
        }

        private static void PrintBottomPart(int figSize, int outerBlank, int innerBlank)
        {
            for (int i = 1; i < figSize/2+1; i++)
            {
                outerBlank--;
                innerBlank+=2;
                Console.Write(string.Concat(Enumerable.Repeat(" ", outerBlank)));
                 Console.Write("x");
                 Console.Write(string.Concat(Enumerable.Repeat(" ",
                innerBlank)));
                 Console.WriteLine("x");
            }
        }

        private static void PrintUpperPart(int figSize, ref int outerBlank, ref int innerBlank)
        {
            for (int i = 1; i <= figSize / 2; i++)
            {
                Console.Write(string.Concat(Enumerable.Repeat(" ", outerBlank)));
                Console.Write("x");
                Console.Write(string.Concat(Enumerable.Repeat(" ", innerBlank)));
                Console.WriteLine("x");
                outerBlank++;
                innerBlank -= 2;
            }
            Console.Write(string.Concat(Enumerable.Repeat(" ", outerBlank)));
            Console.WriteLine("x");
        }
    }
}
