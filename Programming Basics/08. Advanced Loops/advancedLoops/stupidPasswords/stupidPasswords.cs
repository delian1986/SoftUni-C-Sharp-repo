using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stupidPasswords
{
    class stupidPasswords
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (int first = 1; first <= n; first++)
            {
                for (int second = 1; second <= n; second++)
                {
                    for (char third = 'a'; third < ('a'+ l); third++)
                    {
                        for (char four = 'a'; four < ('a'+ l); four++)
                        {
                            for (int fifth = Math.Max(first, second)+1; fifth <= n; fifth++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", first, second, third, four, fifth);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
