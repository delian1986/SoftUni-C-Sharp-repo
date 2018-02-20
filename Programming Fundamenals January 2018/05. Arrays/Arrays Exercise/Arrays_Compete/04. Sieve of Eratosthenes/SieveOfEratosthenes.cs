using System;
using System.Collections.Generic;

namespace _04._Sieve_of_Eratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int numToCheck = int.Parse(Console.ReadLine());
            bool[]primes=new bool[numToCheck+1];

            for (int i = 2; i < primes.Length; i++)
            {
                primes[i]=true;
            }

            for (int i = 2; i <= Math.Sqrt(numToCheck); i++)
            {
                if (primes[i])
                {
                    for (int j = i*i; j <=numToCheck; j+=i)
                    {
                        primes[j]=false;
                    }
                }
            }

            List<int>listRes=new List<int>();
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    listRes.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ",listRes));

        }
    }
}