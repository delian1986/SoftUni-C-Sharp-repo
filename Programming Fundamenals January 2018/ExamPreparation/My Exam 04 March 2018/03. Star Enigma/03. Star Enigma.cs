using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// 100/100
/// </summary>

namespace _03
{
    class Program
    {

        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> attackedPlanets = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> destroyedPlanets = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string text = Console.ReadLine();
                var decript = text.ToCharArray();

                string decriptionPattern = @"[star]";
                RegexOptions ignoreCaseOptions = RegexOptions.IgnoreCase;
                var keyMatches = Regex.Matches(text, decriptionPattern, ignoreCaseOptions);
                int key = keyMatches.Count;
                StringBuilder decripting = new StringBuilder();

                for (int j = 0; j < text.ToCharArray().Length; j++)
                {
                    decripting.Append((char)(text[j] - key));
                }
                
                string decodedMessage = decripting.ToString();

                string starMessagePattern = @"@([a-zA-Z]+)[^@\-!:]*:(\d+)[^@\-!:]*!([AD])![^@\-!:]*->(\d+)";

                var starMatch = Regex.Matches(decodedMessage, starMessagePattern);

                foreach (Match line in starMatch)
                {
                    string planet = line.Groups[1].Value;
                    string population = line.Groups[2].Value;
                    string command = line.Groups[3].Value;
                    string soldierCount = line.Groups[4].Value;

                    //Populating dictionaries.
                    if (command == "A")
                    {
                        if (!attackedPlanets.ContainsKey("Attacked planets"))
                        {
                            attackedPlanets.Add("Attacked planets", new List<string>());
                        }
                        attackedPlanets["Attacked planets"].Add(planet);
                    }
                    else if (command == "D")
                    {
                        if (!destroyedPlanets.ContainsKey("Destroyed planets"))
                        {
                            destroyedPlanets.Add("Destroyed planets", new List<string>());
                        }
                        destroyedPlanets["Destroyed planets"].Add(planet);
                    }
                }

            }
                //Message for attacked planes.
                if (attackedPlanets.Count == 0)
                {
                    Console.WriteLine("Attacked planets: 0");
                }
                else
                {
                    foreach (var atkPlanet in attackedPlanets)
                    {
                        Console.WriteLine($@"Attacked planets: {atkPlanet.Value.Count}");
                        foreach (var planet in atkPlanet.Value.Distinct().OrderBy(x => x))
                        {
                            Console.WriteLine($"-> {planet}");
                        }
                    }
                }

                //Message for destroyed planets.
                if (destroyedPlanets.Count == 0)
                {
                    Console.WriteLine("Destroyed planets: 0");
                }
                else
                {
                    foreach (var destr in destroyedPlanets)
                    {
                        Console.WriteLine($@"Destroyed planets: {destr.Value.Count}");
                        foreach (var palanet in destr.Value.Distinct().OrderBy(x => x))
                        {
                            Console.WriteLine($"-> {palanet}");
                        }
                    }
                }
        }
    }
}

