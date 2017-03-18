using System;

namespace xMassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var outSide = n;
            var needle = 1;
            PrintTree(outSide,needle,n);
        }

        static void PrintTree(int outSide, int needle,int n)
        {
            PrintTop(outSide,needle,n);
            PrintBody(outSide, needle, n);
            PrintTrunk(outSide, n);
        }

        static void PrintTrunk(int outSide, int n)
        {
            outSide = n - 1;

            for (int i = 0; i <n/2+1 ; i++)
            {
                Console.Write(new string('\'', outSide));
                Console.Write(string.Concat("| |"));
                Console.WriteLine(new string('\'', outSide));
            }
            Console.WriteLine(new string('-',n*2+1));
            


        }

        static void PrintBody(int outSide, int needle, int n)
        {
            needle += 2;
            outSide = n - 1;
            for (int i = 0; i < n/2+1; i++)
            {
                Console.Write(new string('\'', outSide));
                Console.Write(new string('^', needle));
                Console.WriteLine(new string('\'', outSide));
                outSide--;
                needle += 2;
            }
        }

        static void PrintTop(int outSide, int needle,int n)
        {
            for (int i = 0; i <n/2+1; i++)
            {
                Console.Write(new string('\'', outSide));
                Console.Write(new string('^',needle));
                Console.WriteLine(new string('\'', outSide));
                outSide--;
                needle += 2;
            }

        }
    }
}
