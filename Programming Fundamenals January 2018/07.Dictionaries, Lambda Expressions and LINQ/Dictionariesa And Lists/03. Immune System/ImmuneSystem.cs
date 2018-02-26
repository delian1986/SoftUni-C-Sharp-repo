using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// This solution needs optimization.
/// https://judge.softuni.bg/Contests/Practice/Index/582#2
/// </summary>

namespace _03._Immune_System
{
    class ImmuneSystemTask
    {
        static void Main(string[] args)
        {
            int immunePower = int.Parse(Console.ReadLine());
            int immuneInitialValue=immunePower;
            Dictionary<string, int> immuneSystem = new Dictionary<string, int>();

            string virus = string.Empty;

            while ((virus = Console.ReadLine()) != "end")
            {
                int virusStrentgh = 0;
                if (!immuneSystem.ContainsKey(virus))
                {
                    int virusPower = 0;
                    foreach (var letter in virus)
                    {
                        virusPower += letter;
                    }
                    virusStrentgh = virusPower / 3;
                    int secondsToDefeat = virusStrentgh * virus.Length;
                    Console.WriteLine($"Virus {virus}: {virusStrentgh} => {secondsToDefeat} seconds");
                    immunePower -= secondsToDefeat;

                    if (immunePower < 0)
                    {
                        Console.WriteLine($"Immune System Defeated.");
                        return;
                    }

                    int min = secondsToDefeat / 60;
                    int sec = (secondsToDefeat % 3600) % 60;

                    Console.WriteLine($"{virus} defeated in {min}m {sec}s.");
                    immuneSystem.Add(virus, (virusStrentgh * virus.Length) / 3);
                }
                else
                {
                    int virusPower = 0;
                    foreach (var letter in virus)
                    {
                        virusPower += letter;
                    }
                    virusStrentgh = virusPower / 3;
                    int secondsToDefeat=immuneSystem[virus];
                      Console.WriteLine($"Virus {virus}: {virusStrentgh} => {secondsToDefeat} seconds");
                    immunePower -= secondsToDefeat;

                    if (immunePower < 0)
                    {
                        Console.WriteLine($"Immune System Defeated.");
                        return;
                    }

                    int min = secondsToDefeat / 60;
                    int sec = (secondsToDefeat % 3600) % 60;

                    Console.WriteLine($"{virus} defeated in {min}m {sec}s.");
                }
                Console.WriteLine($"Remaining health: {immunePower}");
                immunePower+=(int)(immunePower*0.2);
                if (immunePower>immuneInitialValue)
                {
                    immunePower=immuneInitialValue;
                }

            }
            Console.WriteLine($"Final Health: {immunePower}");
        }
    }
}
