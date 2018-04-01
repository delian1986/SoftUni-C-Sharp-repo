using System;
using System.Collections.Generic;

namespace _02.PrimeTriangle
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            //int num = 27;
            //find primes
            List<int> primes = new List<int>();
            primes.Add(1);

            for (int i = 1; i <= num; i++)
            {  //numbers to be checked as prime
                int counter = 0;
                for (int j = 1; j <= i; j++)
                { //all divisible factors


                    if (i % j == 0)
                    {

                        counter++;
                    }
                }

                //prime requires 2 rules ( divisible by 1 and divisible by itself)
                if (counter == 2)
                {

                    primes.Add(i);
                }
            }

            for (int row = 1; row <= primes.Count; row++)
            {
                int count = 1;
                int primesCount = 1;
                while (primesCount <= row)
                {
                    if (primes.Contains(count))
                    {
                        Console.Write(1);
                        primesCount++;
                    }
                    else
                    {
                        Console.Write(0);
                    }
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}

