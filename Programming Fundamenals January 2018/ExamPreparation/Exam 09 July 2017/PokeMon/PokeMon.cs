using System;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/691#0
/// 100/100
/// </summary>
namespace PokeMon
{
    class PokeMon
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exaust = int.Parse(Console.ReadLine());
            int count = 0;
            int stamina =pokePower;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                count++;

                //We check if the power is exacly 50% of intial value and
                //division if possible.
                if (pokePower == stamina*0.5 && exaust > 0)
                {
                    pokePower /= exaust;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
