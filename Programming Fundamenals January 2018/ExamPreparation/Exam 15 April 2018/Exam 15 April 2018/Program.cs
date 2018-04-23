using System;

/// <summary>
/// 100/100
/// </summary>

namespace Exam_15_April_2018
{
    class Program
    {
        static void Main()
        {
            int memberCount = int.Parse(Console.ReadLine());
            decimal guitarPrice = decimal.Parse(Console.ReadLine());

            int vocalist = 1;
            int guitarists = memberCount / 3;
            int drummers = memberCount - vocalist - guitarists;
            decimal drumPrice = (guitarPrice * 0.5m) + guitarPrice;
            decimal allDrumPrice = drummers * drumPrice;
            decimal allGuitarsPrice = guitarists * guitarPrice;

            decimal micPrice = Math.Abs(allDrumPrice - allGuitarsPrice);
            decimal rentPerMounth = (allDrumPrice + allGuitarsPrice + micPrice) / memberCount;
            decimal rentPerYear = rentPerMounth * 12;

            decimal total = allDrumPrice + allGuitarsPrice + micPrice + rentPerYear;

            Console.WriteLine($"Total cost: {total:f2}lv.");
        }
    }
}
