using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var even = 0;
            var odd = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even = even + num;
                    
                }
                else
                {
                    odd = odd + num;
                }
                

            }
            if (even - odd == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+ odd);
            }
            else
            {
                Console.WriteLine("No");
                var diff = (Math.Abs(even - odd));
                Console.WriteLine("Diff = "+diff);
            }
        }
    }
}
