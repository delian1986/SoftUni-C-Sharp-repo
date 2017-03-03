using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOddPos
{
    class oddEvenPos
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var evenSum = 0.0;
            var oddSum = 0.0;
            var evenMax = double.MinValue;
            var evenMin = double.MaxValue;
            var oddMax = double.MinValue;
            var oddMin = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (evenMax < num)
                    {
                        evenMax = num;
                    }
                    if (evenMin > num)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (oddMin > num)
                    {
                        oddMin = num;
                    }
                    if (oddMax < num)
                    {
                        oddMax = num;
                    }
                }
            }
            if (n == 1)
            {
                Console.WriteLine("OddSum={0}," , oddSum);
                Console.WriteLine("OddMin={0}," , oddMin);
                Console.WriteLine("OddMax={0}," , oddMax);
                Console.WriteLine("EvenSum=0,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n==0)
            {
                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else 
            {
                Console.WriteLine("OddSum={0}," , oddSum);
                Console.WriteLine("OddMin={0}," , oddMin);
                Console.WriteLine("OddMax={0}," , oddMax);
                Console.WriteLine("EvenSum={0}," , evenSum);
                Console.WriteLine("EvenMin={0}," , evenMin);
                Console.WriteLine("EvenMax= "+ evenMax);
            }
        }
    }
}
