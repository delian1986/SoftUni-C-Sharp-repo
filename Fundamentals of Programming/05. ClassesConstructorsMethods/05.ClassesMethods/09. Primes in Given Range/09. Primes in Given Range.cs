using System;
using System.Collections.Generic;


namespace _09.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            var res = FoundPrimes(num1, num2);

            Console.WriteLine(string.Join(", ", res));
            
        }
        static List<int> FoundPrimes (int num1,int num2)
        {
            List<int> primes = new List<int>();
           
            var counter = 0;
            if (num1 < 0 || num2 < 0)
            {
                num1 = 2;
            }
            if (num1 == 0 || num1 == 1)
            {
                num1 = 2;
            }
            if (num1 > num2)
            {
                Console.WriteLine("Empty list");
            }

            for (int i = num1; i <= num2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                    if (counter > 2)
                    {
                        break;
                    }
                }
                if (counter <= 2)
                {
                    primes.Add(i);
                }
                counter = 0;
            }
            return primes;
        }
    }
}
