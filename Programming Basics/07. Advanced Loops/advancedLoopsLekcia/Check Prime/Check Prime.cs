using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <=Math.Sqrt(n); i++)
            {
                if (n%i==0)
                {
                    isPrime = false;

                    break;
                }
                else
                {
                    isPrime = true;
                }

            }
            if (!isPrime||n<2)
            {
                Console.WriteLine("Not Prime");
            }
            else if (isPrime)
            {
                Console.WriteLine("Prime");
            }

        }
    }
}
