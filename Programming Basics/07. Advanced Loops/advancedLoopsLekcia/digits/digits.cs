using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digits
{
    class digits
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num= n % 10;
            var dec = n / 10 % 10;
            var hund = n / 10 / 10 % 10;

            for (int rol = 1; rol <= hund + dec; rol++)
            {
                for (int col = 1; col <= hund + num; col++)
                {
                    if (n % 5 == 0)
                    {
                        n -= hund;
                        Console.Write(n + " ");
                    }
                    else if (n % 3 == 0)
                    {
                        n -= dec;
                        Console.Write(n + " ");
                    }
                    else 
                    {
                        n += num;
                        Console.Write(n + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
