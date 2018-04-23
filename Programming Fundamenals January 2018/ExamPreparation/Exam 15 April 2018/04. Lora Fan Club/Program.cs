using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 80/100
/// </summary>

namespace _04._Lora_Fan_Club
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> traits = new Dictionary<string, int>
            {
                { "Greedy",-1 },
                {"Rude",-1 },
                {"Dumb",-1 },
                {"Kind",2 },
                {"Handsome",3 },
                {"Smart",5 },
                
            };

            Dictionary<string, long> sumOfScores = new Dictionary<string, long>();

            Dictionary<string, Dictionary<string, int>> fansList = new Dictionary<string, Dictionary<string, int>>();

            string line = String.Empty;

            while ((line = Console.ReadLine()) != "Make a decision already!")
            {
                string[] args = line.Split();

                string name = args[0];
                string trait = args[1];
                int num = 0;

                if (trait != "does")
                {
                    num = int.Parse(args[2]);
                    if (traits.ContainsKey(trait))
                    {
                        int currModifier = traits[trait];
                        num *= currModifier;
                    }

                    if (!fansList.ContainsKey(name))
                    {
                        fansList.Add(name, new Dictionary<string, int>());
                    }

                    if (fansList[name].ContainsKey(trait))
                    {
                        int currScore = fansList[name][trait];

                        if (num > currScore)
                        {
                            fansList[name][trait] = num;
                        }
                    }
                    if (!fansList[name].ContainsKey(trait))
                    {
                        fansList[name].Add(trait, num);
                    }
                }
                else
                {
                    if (fansList.ContainsKey(name))
                    {
                            fansList.Remove(name);
                            sumOfScores.Add(name, 0);
                    }                      
                }

            }

            foreach (var fan in fansList)
            {
                if (!sumOfScores.ContainsKey(fan.Key))
                {
                    sumOfScores.Add(fan.Key, 0);
                }
                foreach (var score in fan.Value)
                {
                    sumOfScores[fan.Key] += score.Value;
                }
            }

            foreach (var boy in sumOfScores.OrderByDescending(x=>x.Value).ThenBy(y=>y.Key))
            {
                Console.WriteLine($"# {boy.Key}: {boy.Value}");

                if (fansList.ContainsKey(boy.Key))
                {
                    foreach (var trait in fansList[boy.Key].OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"!!! {trait.Key} -> {trait.Value}");
                    }
                }
            }
        }
    }
}
