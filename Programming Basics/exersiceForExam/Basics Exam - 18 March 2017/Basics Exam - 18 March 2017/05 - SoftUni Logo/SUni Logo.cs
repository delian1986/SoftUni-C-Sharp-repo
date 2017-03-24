using System;

namespace _05___SoftUni_Logo
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var hat = 7;
            PrintLogo(n,hat);
        }

        static void PrintLogo(int n,int hat)
        {
            PrintTop(n);
            PrintUpperBody(n,hat);
            PrintBottomBody(n,hat);
            PrintEnd(n,hat);
        }

        static void PrintEnd(int n, int hat)
        {
            var dots = ((12*n-5)-(6*n+1))/2;
            for (int end = 1; end <=n-1; end++)
            {
                Console.Write('|');
                Console.Write(new string('.',dots-1));
                Console.Write(new string('#',6*n+1));
                Console.WriteLine(new string('.',dots));
                if (end==n-1)
                {
                    Console.Write('@');
                    Console.Write(new string('.', dots-1));
                    Console.Write(new string('#', 6 * n + 1));
                    Console.WriteLine(new string('.', dots));

                }
            }
        }

        static void PrintBottomBody(int n, int hat)
        {
            var dots = 2;
            hat = 12 * n - 11;

            for (int botBody = 1; botBody <=n-2; botBody++)
            {
                Console.Write('|');
                Console.Write(new string('.',dots));
                Console.Write(new string('#',hat));
                Console.WriteLine(new string('.', dots+1));
                hat -= 6;

                dots += 3;
            }
        }

        static void PrintUpperBody(int n,int hat)
        {
            var dots = 6 * n - 6;
            for (int rows = 1; rows <=2*n-1; rows++)
            {
                Console.Write(new string('.',dots));
                Console.Write(new string('#',hat));
                Console.WriteLine(new string('.', dots));

                dots -= 3;
                hat += 6;

            }
        }

        static void PrintTop(int n)
        {
            Console.Write(new string('.', 6 * n - 3));
            Console.Write("#");
            Console.WriteLine(new string('.', 6 * n - 3));

        }
    }
}