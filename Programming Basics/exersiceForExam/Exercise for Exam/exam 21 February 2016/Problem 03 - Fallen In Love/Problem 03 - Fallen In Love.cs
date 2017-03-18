using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Fallen_In_Love
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            PrintFigure(n);
        }

        private static void PrintFigure(int n)
        {
            PrintUpperPart(n);
            PrintMiddle(n);
            Console.WriteLine(new string('.', 2 * n + 1)+ "####"+ new string('.', 2 * n + 1));
            PrintBottom(n);
        }

        private static void PrintBottom(int n)
        {
            for (int i =1; i <=n; i++)
            {
                Console.Write(new string('.',2*n+2));
                Console.Write("##");
                Console.WriteLine(new string('.', 2 * n + 2));

            }
        }

        private static void PrintMiddle(int n)
        {
            var outerDot = 1;
            var amper = n;
            var innerDot = 2 * n;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string ('.',outerDot));
                Console.Write("#");
                Console.Write(new string('~',amper));
                Console.Write("#");
                Console.Write(new string('.', innerDot));
                Console.Write("#");
                Console.Write(new string('~', amper));
                Console.Write("#");
                Console.WriteLine(new string('.', outerDot));

                outerDot += 2;
                amper--;
                innerDot -= 2;
            }
        }

        private static void PrintUpperPart(int n)
        {
            var amper = 0;
            var outerDots = n * 2;
            var innerDots = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("#");
                Console.Write(new string('~', amper));
                Console.Write("#");
                Console.Write(new string('.', outerDots));
                Console.Write("#");
                Console.Write(new string('.', innerDots));
                Console.Write("#");
                Console.Write(new string('.', outerDots));
                Console.Write("#");
                Console.Write(new string('~', amper));
                Console.WriteLine("#");
                amper++;
                outerDots -= 2;
                innerDots += 2;
            }
        }
    }
}
