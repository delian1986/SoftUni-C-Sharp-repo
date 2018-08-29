using System;

namespace _02._Recursive_Factorial
{
    class Program
    {
        static void Main()
        {
            int n=int.Parse(Console.ReadLine());

            long result=Factorial(n);

            Console.WriteLine(result);
        }

        private static long Factorial(int n)
        {
            if (n==0)
            {
                return 1;
            }

            return n* Factorial(n-1);
        }
    }
}
