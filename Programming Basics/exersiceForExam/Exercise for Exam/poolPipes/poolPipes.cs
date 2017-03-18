using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poolPipes
{
    class poolPipes
    {
        static void Main(string[] args)
        {
            double v = double.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            var p1Total = p1 * h;
            var p2Total = p2 * h;
            var totalPool = p1Total + p2Total;
            if (totalPool<=v)
            {
                var p1Percent =Math.Truncate( p1Total / totalPool * 100);
                var p2Percent = Math.Truncate(p2Total / totalPool * 100);
                var poolPerc = Math.Truncate(totalPool / v * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",poolPerc,p1Percent,p2Percent);
            }
            else
            {
                var overFlow = totalPool - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h,overFlow);
            }
        }
    }
}
