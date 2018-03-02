using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/741#0
/// 100/100
/// </summary>

namespace _01._Trainers
{
    class Trainers
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Dictionary<string, decimal> bestTrainers = new Dictionary<string, decimal>()
            {
                {"Technical",0},
                {"Practical",0 },
                {"Theoretical",0}
            };

            for (long i = 0; i < num; i++)
            {
                long distance = long.Parse(Console.ReadLine());
                decimal cargo = decimal.Parse(Console.ReadLine());
                string teamName = Console.ReadLine();

                decimal cargoInKg = cargo * 1000m;
                decimal distInMeters = distance * 1600m;
                decimal fuelCons = distInMeters * 0.7m;
                decimal fuelPrice = fuelCons * 2.5m;
                decimal cargoIncome = cargoInKg * 1.5m;
                decimal result = cargoIncome - fuelPrice;

                bestTrainers[teamName] += result;

            }

            
            var best=bestTrainers.OrderByDescending(x=>x.Value).First();

             Console.WriteLine($"The {best.Key} Trainers win with ${best.Value:f3}.");
        }
    }
}