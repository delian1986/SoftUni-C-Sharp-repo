using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leftAndRightSum
{
    class leftRight
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                
                sum1 += num1;
            }
            for (int i = 0; i < n; i++)
            {
                var num3 = int.Parse(Console.ReadLine());
               
                sum2 += num3;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = " + sum2);
            }
            else
            {
                var res = Math.Abs(sum1 - sum2);
                Console.WriteLine("No, diff = " + res);
            }
        }
    }
}

