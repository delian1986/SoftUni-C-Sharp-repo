using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.rocket
{
    class rocket
    {
        static void Main(string[] args)
        {
            decimal n = int.Parse(Console.ReadLine());

            //top
            decimal topDots = (3 * n) / 2 - 1;
            decimal space = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', topDots));
                Console.Write('/');
                Console.Write(new string(' ', space));
                Console.Write('\\');
                Console.WriteLine(new string('.', topDots));
                topDots--;
                space += 2;
            }

            //mid
            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', space));
            Console.WriteLine(new string('.', n / 2));

            //body
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write('|');
                Console.Write(new string('\\', space - 2));
                Console.Write('|');

                Console.WriteLine(new string('.', n / 2));
            }

            //bott
            decimal botDot = n / 2;
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.', botDot));
                Console.Write('/');
                Console.Write(new string('*', space-2));
                Console.Write('\\');
                Console.WriteLine(new string('.', botDot));
                botDot--;
                space+=2;
            }
        }
    }
}
