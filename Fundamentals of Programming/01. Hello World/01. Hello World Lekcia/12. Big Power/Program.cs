using System;
using System.Numerics;
namespace _12.Big_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // BigInteger bigN = (BigInteger)Math.Pow(n, n);
            Console.WriteLine(BigInteger.Pow(n, n));

        }
    }
}
