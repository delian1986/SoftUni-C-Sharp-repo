using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    p2 += 1;
                }
                if (num%3==0)
                {
                    p3 += 1;
                }
                if (num%4==0)
                {
                    p4 += 1;
                }
            }
            var p2Perc = p2 / n * 100;
            var p3Perc = p3 / n * 100;
            var p4Perc = p4 / n * 100;

            Console.WriteLine("{0:f2}%",p2Perc);
            Console.WriteLine("{0:f2}%", p3Perc);
            Console.WriteLine("{0:f2}%", p4Perc);


        }
    }
}
