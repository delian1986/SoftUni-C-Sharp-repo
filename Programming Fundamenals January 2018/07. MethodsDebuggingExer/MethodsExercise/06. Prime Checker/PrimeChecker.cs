using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            bool prime = IsPrime(num);
            Console.WriteLine(prime);
        }

        private static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <num; i++)
                {
                    for (int j = 2; j <num; j++)
                    {
                        if (j * i == num)
                        {
                            return false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            return true;
        }
    }
}
