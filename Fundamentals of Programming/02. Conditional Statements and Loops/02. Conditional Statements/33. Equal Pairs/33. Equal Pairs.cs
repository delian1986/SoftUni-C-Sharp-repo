using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int diff = 0;
            int prevSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                int newNum1 = int.Parse(Console.ReadLine());

                sum = newNum + newNum1;

                if(i>1&&Math.Abs(sum-prevSum)>diff)
                {
                    diff = Math.Abs(sum - prevSum);
                }

                prevSum = sum;
            }
            if (diff==0)
            {
            Console.WriteLine($"Yes, value={sum}");

            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }

        }
    }
}
