using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histogram
{
    class histogram
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var nums = n;
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            var p4 = 0;
            var p5 = 0;


            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());


                if (num >= 0 && num < 200)

                {
                    p1++;
                }
                else if (num>=200&&num<400)
                {
                    p2++;
                }
                else if (num>=400&&num<600)
                {
                    p3++;
                }
                else if (num>=600&num<800)
                {
                    p4++;
                }
                else if (num>=800)
                {
                    p5++;
                }
            }
            var p1Perc = (p1 / n) * 100;
            var p2Perc = (p2 / n) * 100;
            var p3Perc = (p3 / n) * 100;
            var p4Perc = (p4 / n) * 100;
            var p5Perc = (p5 / n) * 100;

            Console.WriteLine("{0:f2}%",p1Perc);
            Console.WriteLine("{0:f2}%", p2Perc);
            Console.WriteLine("{0:f2}%", p3Perc);
            Console.WriteLine("{0:f2}%", p4Perc);
            Console.WriteLine("{0:f2}%", p5Perc);


        }
    }
}
