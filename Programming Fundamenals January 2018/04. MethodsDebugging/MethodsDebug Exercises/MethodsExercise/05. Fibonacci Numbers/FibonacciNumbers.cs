using System;

namespace _05._Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int fibonaccci = int.Parse(Console.ReadLine())+1;

            FindFibonacci(fibonaccci);
        }

        private static void FindFibonacci(int fibonaccci)
        {
            //if ()
            //{
            //
            //}
            int[] fib = new int[fibonaccci + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= fib.Length-1; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
                Console.WriteLine(fib[i]);
            }


        }
    }
}
