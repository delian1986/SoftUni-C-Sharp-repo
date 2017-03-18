using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var empty = n * 2 - 2;
            if (n==2)
            {
                Console.WriteLine("%%%%\n%**%\n%%%%");
                return;
            }
            //top   bott
            Console.WriteLine(new string('%', n * 2));

            //chetni
            if (n % 2 == 0)
            {
                for (int i = 1; i < n-1; i++)
                {
                    if (n/2==i)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', empty / 2 - 1));
                        Console.Write("**");
                        Console.Write(new string(' ', empty / 2 - 1));
                        Console.WriteLine("%");
                    }
                    Console.Write("%");
                    Console.Write(new string(' ', empty));
                    Console.WriteLine("%");
                }
            }

            //nechetni
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (n / 2 == i)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', empty / 2 - 1));
                        Console.Write("**");
                        Console.Write(new string(' ', empty / 2 - 1));
                        Console.WriteLine("%");
                    }
                    Console.Write("%");
                    Console.Write(new string(' ', empty));
                    Console.WriteLine("%");

                }
            }

            //bott
            Console.WriteLine(new string('%', n * 2));

        }
    }
}
