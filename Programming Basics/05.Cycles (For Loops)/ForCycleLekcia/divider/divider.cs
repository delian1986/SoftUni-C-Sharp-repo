using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divider
{
    class divider
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            var p1 = 0;
            var p2 = 0;
            var p3 = 0;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (num%2==0)
                {
                    p1++;
                }
                if (num%3==0)
                {
                    p2++;
                }
                if (num%4==0)
                {
                    p3++;
                }
            }
            var p1Perc = (p1 / n) * 100;
            var p2Perc = (p2 / n) * 100;
            var p3Perc = (p3 / n) * 100;
            Console.WriteLine("{0:f2}%",p1Perc);
            Console.WriteLine("{0:f2}%", p2Perc);
            Console.WriteLine("{0:f2}%", p3Perc);

        }
    }
}
