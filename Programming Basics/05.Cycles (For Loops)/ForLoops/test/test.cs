using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class test
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var maxVal = int.MinValue;

            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var nums = int.Parse(Console.ReadLine());
                sum += nums;
                if (nums > maxVal)
                {
                    maxVal = nums;
                }
            }
            if ((sum - maxVal) == maxVal)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxVal);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+Math.Abs((sum - maxVal) - maxVal));
            }
        }
    }
}