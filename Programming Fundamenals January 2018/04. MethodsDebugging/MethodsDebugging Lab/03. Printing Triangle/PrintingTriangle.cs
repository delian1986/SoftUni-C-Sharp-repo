using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int sizeOfTriangle = int.Parse(Console.ReadLine());
            for (int i = 1; i < sizeOfTriangle; i++)
            {
                PrintLine(1, i);

            }
            
                PrintLine(1, sizeOfTriangle);

            for (int i = sizeOfTriangle - 1; i >= 0; i--)
            {
                PrintLine(1,i);
            }

        }

        private static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
