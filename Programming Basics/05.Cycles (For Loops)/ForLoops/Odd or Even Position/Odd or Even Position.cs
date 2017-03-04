using System;

namespace Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            var oddMin = 100000000.0;
            var oddMax = -100000000.0;
            var oddSum = 0.0;

            var evenMin = 100000000.0;
            var evenMax = -100000000.0;
            var evenSum = 0.0;

            for (int i = 0; i < n; i++)
            {
                var nums = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (oddMax < nums)
                    {
                        oddMax = nums;
                    }
                    if (oddMin > nums)
                    {
                        oddMin = nums;
                    }
                    oddSum += nums;
                }
                else
                {
                    if (evenMax < nums)
                    {
                        evenMax = nums;
                    }
                    if (evenMin > nums)
                    {
                        evenMin = nums;
                    }
                    evenSum += nums;
                }
            }
            if (n == 0)
            {
                Console.WriteLine("OddSum = 0");
                Console.WriteLine("OddMin = No");
                Console.WriteLine("OddMax = No");
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum = " + oddSum);
                Console.WriteLine("OddMin = " + oddMin);
                Console.WriteLine("OddMax = " + oddMax);
                Console.WriteLine("EvenSum = " + evenSum);
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }

            else
            {
                Console.WriteLine("OddSum = " + oddSum);
                Console.WriteLine("OddMin = " + oddMin);
                Console.WriteLine("OddMax = " + oddMax);
                Console.WriteLine("EvenSum = " + evenSum);
                Console.WriteLine("EvenMin = " + evenMin);
                Console.WriteLine("EvenMax = " + evenMax);
            }


        }
    }
}

