using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/742#1
/// </summary>

namespace Trainlands
{
    public class Wagon
    {
        public string Name { get; set; }
        public int Power { get; set; }
    }

    class Trainlands
    {

        static void Main()
        {
            Dictionary<string, List<Wagon>> trains = new Dictionary<string, List<Wagon>>();
            Dictionary<string, long> power = new Dictionary<string, long>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "It's Training Men!")
            {
                string[] args = input.Split(new[] { ' ', '>', '-', '=', ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (args.Length == 3)
                {
                    string trainName = args[0];
                    string wagName = args[1];
                    int warPow = int.Parse(args[2]);

                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new List<Wagon>());
                    }
                    Wagon wag = new Wagon() { Name = wagName, Power = warPow };
                    trains[trainName].Add(wag);
                }
                else if (args.Length == 2)
                {
                    string[] command = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (command[1] == "->")
                    {
                        string firstTrain = args[0];
                        string secTrain = args[1];

                        var sec = trains.First(x => x.Key == secTrain);
                        var secWag = sec.Value.ToList();
                        if (trains.ContainsKey(firstTrain))
                        {
                            trains[firstTrain].AddRange(secWag);
                        }
                        else
                        {
                            trains.Add(firstTrain, secWag);
                        }
                        trains.Remove(secTrain);
                    }
                    else if (command[1] == "=")
                    {
                        string firstTrain = args[0];
                        string secTrain = args[1];

                        var sec = trains.First(x => x.Key == secTrain);
                        var secWag = sec.Value.ToList();

                        trains[firstTrain] = new List<Wagon>();
                        trains[firstTrain].AddRange(secWag);
                    }

                }
            }
            foreach (var train in trains)
            {
                power.Add(train.Key, 0);

                foreach (var wag in train.Value)
                {
                    power[train.Key] += wag.Power;
                }
            }
            var ordered = trains
            .OrderByDescending(x => power[x.Key])
            .ThenBy(x => x.Value.Count)
           .ToDictionary(x => x.Key, y => y.Value);

            foreach (var train in ordered)
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var wag in train.Value.OrderByDescending(x => x.Power))
                {
                    Console.WriteLine($"###{wag.Name} - {wag.Power}");
                }
            }
        }
    }


}



