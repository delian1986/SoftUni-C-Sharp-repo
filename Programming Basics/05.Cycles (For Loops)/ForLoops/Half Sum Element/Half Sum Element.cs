using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var maxNum = int.MinValue;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num >= maxNum)
                {
                    maxNum = num;
                    sum += num;
                }
                else
                {
                    sum += num;
                }

            }
            if ((sum-maxNum) == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNum);
            }
            else
            {
                var res = Math.Abs((sum-maxNum) - maxNum);
                Console.WriteLine("No");
                Console.WriteLine("diff = "+ res);
            }
        }
    }
}
