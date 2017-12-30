using System;


namespace _08.Prime_Checker
{
    class Program
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());

            bool prime = IsPrime(n);
            string res = PrimeToString(prime);

            Console.WriteLine(res);
        }

        private static string PrimeToString(bool prime)
        {
            if (prime == true)
            {
                return "True";
            }
            return "False";
        }

        private static bool IsPrime(ulong n)
        {
            if (n == 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }

            for (ulong i = 2; i <= Math.Ceiling( Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
                    return true;

        }
    }
}
