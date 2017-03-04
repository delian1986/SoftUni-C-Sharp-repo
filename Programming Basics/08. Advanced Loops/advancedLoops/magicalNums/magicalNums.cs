using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicalNums
{
    class magicalNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 1; first <= n; first++)
            {
                for (int second = 1; second <= n; second++)
                {
                    for (int third = 1; third <= n; third++)
                    {
                        for (int four = 1; four <= n; four++)
                        {
                            for (int five = 1; five <= n; five++)
                            {
                                for (int six = 1; six <= n; six++)
                                {
                                    if (first * second * third * four * five * six == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", first, second, third, four, five, six);
                                    }

                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
