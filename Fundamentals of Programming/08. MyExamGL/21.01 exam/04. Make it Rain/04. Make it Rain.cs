using System;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/919#3
/// </summary>
namespace _04.Make_it_Rain
{
    class Program
    {
        static void Main()
        {
            //Number of input lines.
            int n = int.Parse(Console.ReadLine());

            //special Arguments.
            int tCount = 0;
            int fCount = 0;

            for (int i = 0; i < n; i++)
            {
                //Arguments.
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                bool isDivided = false;

                //Checking if dividing is possible.
                try
                {
                    if (a/b==c)
                    {
                        isDivided = true;
                    }
                }
                catch 
                {
                    isDivided = false;
                }

                int resultFromDividing = 0;

                //Calculating special formula.
                if (isDivided)
                {
                    resultFromDividing = 'T';
                    tCount += resultFromDividing;
                    fCount /= resultFromDividing / 10;
                }
                else
                {
                    resultFromDividing = 'F';
                    fCount += resultFromDividing;
                    tCount /= resultFromDividing / 10;
                }
            }

            //Checking if we got RoinCoin.
            bool isRoin = false;
            try
            {
                if ((tCount/fCount)%2==0)
                {
                    isRoin = true;
                }
            }
            catch
            {
                isRoin = false;
            }

            Console.WriteLine($"T: {tCount}");
            Console.WriteLine($"F: {fCount}");
            Console.WriteLine($"Got a Roin coin: {isRoin}");
        }
    }
}
