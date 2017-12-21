using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintTriangle(num);
        }

        private static void PrintTriangle(int num)
        {
            UpperPartOfTriangle(num);
            BottomPartOfTriangle(num);
        }

        private static void BottomPartOfTriangle(int num)
        {
            for (int i = num - 1; i > 0; i--)
            {
                RownsANdCols(i);
            }
        }

        private static void UpperPartOfTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                RownsANdCols(i);
            }
        }

        private static void RownsANdCols(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }

    }
}
