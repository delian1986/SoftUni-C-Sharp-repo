using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int numToCheck = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numToCheck; i++)
            {
                bool isItPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(i); divider++)
                {
                    if (i % divider == 0)
                    {
                        isItPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isItPrime}");
            }

        }
    }
}
