using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halfSumElement
{
    class halfSumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num>max)
                {
                    max = num;
                }
            }
            if (sum-max==max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+max);
            }
            else
            {
                var res = Math.Abs((sum-max)-max);
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+res);
            }
        }
    }
}
