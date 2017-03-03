using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunglases
{
    class sunglases
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i==1||i==n)
                {
                    Console.Write(new string('*',2*n));
                    Console.Write(new string(' ',n));
                    Console.Write(new string('*',2*n));
                }
                else
                {
                    Console.Write('*');
                    Console.Write(new string('/',(n*2)-2));
                    Console.Write('*');
                    if (n%2==0)
                    {
                        if (i==n/2)
                        {
                            Console.Write(new string('|', n));

                        }
                        else
                        {
                            Console.Write(new string(' ', n));

                        }

                    }
                    else
                    {
                        if (i == (n / 2) + 1)
                        {
                            Console.Write(new string('|', n));
                        }
                        else
                        {
                            Console.Write(new string(' ', n));
                        }
                    }
                    
                    
                    Console.Write('*');
                    Console.Write(new string('/', (n * 2) - 2));
                    Console.Write('*');
                }
               

                Console.WriteLine();
            }
        }

    }
}
