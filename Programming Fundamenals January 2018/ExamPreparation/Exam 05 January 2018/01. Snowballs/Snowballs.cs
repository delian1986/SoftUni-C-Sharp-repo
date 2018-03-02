using System;
using System.Collections.Generic;
using System.Numerics;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/906#0
/// </summary>

namespace _01._Snowballs
{
    class Snowballs
    {
        static void Main()
        {
            int numOfBalls = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger biggestValue = long.MinValue;
            List<BigInteger> biggestVals = new List<BigInteger>();

            for (int i = 0; i < numOfBalls; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = (BigInteger.Pow((snowballSnow / snowballTime), snowballQuality));

                if (snowballValue >= biggestValue)
                {
                    biggestVals.Clear();
                    biggestValue = snowballValue;
                    biggestVals.Add(snowballSnow);
                    biggestVals.Add(snowballTime);
                    biggestVals.Add(snowballQuality);
                }

            }
            Console.WriteLine($"{biggestVals[0]} : {biggestVals[1]} = {biggestValue} ({biggestVals[2]})");
        }
    }
}
