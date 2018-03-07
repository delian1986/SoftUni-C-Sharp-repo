using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFigure(n);
        }

        static void PrintFigure(int n)
        {
            PrintHeader(n);
            PrintBody(n);
            PrintHeader(n);

        }

        static void PrintBody(int n)
        {
            for (int i = 0; i <n-2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }

    }
}
