using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareFrame
{
    class squareFrame
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int dash = n-2;
            for (int i = 1; i <= n; i++)
            {
                if (i==1||i==n)
                {
                    Console.Write('+');

                    for (int j = 0; j < n-2; j++)
                    {
                        Console.Write(" -");
                    }
                        Console.WriteLine(" +");

                }
                else
                {
                    Console.Write("| ");

                    for (int k = 1; k <= n-2; k++)
                    {

                        Console.Write("- ");

                    }
                    Console.WriteLine("|");
                }

               
            }
        }
    }
}
