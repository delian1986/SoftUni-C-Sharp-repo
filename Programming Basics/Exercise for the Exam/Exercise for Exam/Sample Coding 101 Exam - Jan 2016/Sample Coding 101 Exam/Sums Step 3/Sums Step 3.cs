using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 0;
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var step = 3;
            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                switch (i%3)
                {
                    case 0:sum1 += num;
                        break;
                    case 1: sum2 += num;
                        break;
                    case 2: sum3 += num;
                        break;
                }
            }
            Console.WriteLine("sum1 = "+sum2);
            Console.WriteLine("sum2 = "+sum3);
            Console.WriteLine("sum3 = "+sum1);

        }
    }
}
