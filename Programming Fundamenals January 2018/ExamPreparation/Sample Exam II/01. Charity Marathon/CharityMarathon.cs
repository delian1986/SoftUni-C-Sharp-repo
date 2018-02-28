using System;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/454#0
/// 100/100
/// </summary>

namespace _01._Charity_Marathon
{
    class Program
    {
        static void Main()
        {
            long days=long.Parse(Console.ReadLine());
            long runnerCount=long.Parse(Console.ReadLine());
            long avgLaps=long.Parse(Console.ReadLine());
            long lapLength=long.Parse(Console.ReadLine());
            long capacity=long.Parse(Console.ReadLine());
            decimal money=decimal.Parse(Console.ReadLine());

            if (capacity*days<runnerCount)
            {
                runnerCount=capacity*days;
            }
            long totalKilometers=(runnerCount*avgLaps*lapLength)/1000;
            decimal moneyRaised= money*totalKilometers;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
