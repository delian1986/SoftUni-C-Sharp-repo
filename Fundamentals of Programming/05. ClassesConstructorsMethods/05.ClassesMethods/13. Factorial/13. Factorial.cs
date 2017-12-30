using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger num = 1;

        for (int i = 1; i <= n; i++)
        {
            num *= i;
        }
        Console.WriteLine(num);
    }
}

