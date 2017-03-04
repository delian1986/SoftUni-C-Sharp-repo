using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var digits = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int col = 1; col <= i; col++)
                {
                    Console.Write(digits + " ");
                    digits += 1;
                    if (digits > n)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
