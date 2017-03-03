using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butterfly
{
    class buterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var rol = 2 * (n - 2) + 1;
            var col = 2 * n - 1;
            var oneColWing = n - 1;
            var oneRowWing = (rol / 2) - 1;
            var star = n - 2;


            for (int j = 0; j < rol / 2 + 1; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write(@"\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('*', n - 2));
                }
                else if (rol / 2 == j)
                {
                    Console.Write(new string(' ', n - 1));
                    Console.WriteLine("@");

                }
                else if (j % 2 != 0)
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write(@"\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('-', n - 2));
                }
            }
            for (int i = 0; i < rol/2; i++)
            {
                if (i%2==0)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write(@"\");
                    Console.WriteLine(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write(@"\");
                    Console.WriteLine(new string('-', n - 2));
                }
               
            }


        }

    }
}

