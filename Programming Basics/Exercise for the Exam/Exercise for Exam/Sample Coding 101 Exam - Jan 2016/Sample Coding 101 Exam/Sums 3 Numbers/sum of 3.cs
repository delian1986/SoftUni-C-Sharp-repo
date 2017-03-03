using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                var low = Math.Min(a, b);
                var max = Math.Max(b, a);
                Console.WriteLine("{0} + {1} = {2}",low,max,c);
                return;

            }
            if (a + c == b)
            {
                var low = Math.Min(a, c);
                var max = Math.Max(a, c);

                Console.WriteLine("{0} + {1} = {2}",low,max,b);
                return;

            }
            if (b+c==a)
            {
                var low = Math.Min(b, c);
                var max = Math.Max(b, c);
                Console.WriteLine("{0} + {1} = {2}",low,max,a);
                return;

            }

            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
