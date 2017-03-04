using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var p1Count = 0.0;
            var p2Count = 0.0;
            var p3Count = 0.0;
            var p4Count = 0.0;
            var p5Count = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num > 0 && num < 200)
                {
                    p1Count += 1;
                }
                else if (num >= 200 && num < 400)
                    p2Count += 1;

                else if (num >= 400 && num < 600)

                    p3Count += 1;

                else if (num >= 600 && num < 800)

                    p4Count += 1;
                else if (num >= 800)
                {
                    p5Count += 1;
                }

            }
            var p1Perc = p1Count / n * 100;
            var p2Perc = p2Count / n * 100;
            var p3Perc = p3Count / n * 100;
            var p4Perc = p4Count / n * 100;
            var p5Perc = p5Count / n * 100;

            Console.WriteLine("{0:f2}%",p1Perc);
            Console.WriteLine("{0:f2}%", p2Perc);
            Console.WriteLine("{0:f2}%", p3Perc);
            Console.WriteLine("{0:f2}%", p4Perc);
            Console.WriteLine("{0:f2}%", p5Perc);


        }
    }
}


