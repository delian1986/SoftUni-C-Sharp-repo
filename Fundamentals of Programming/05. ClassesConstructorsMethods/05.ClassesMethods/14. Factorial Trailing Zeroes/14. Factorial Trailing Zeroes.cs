using System;
using System.Numerics;

class FactorialTrailingZeroes
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger num = 1;

        for (int i = 1; i <= n; i++)
        {
            num *= i;
        }
        var bigNum = num.ToString();
        var counter = 0;
        for (int i = bigNum.Length-1; i >0 ; i--)
        {
            if (bigNum[i] =='0')
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(counter);
    }
}
