using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 60/100
/// </summary>

namespace _04
{
    class Paduan
    {
        public string Name { get; set; }
        public string Side { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    string[] args = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                    string forceSide = args[0];
                    string user = args[1];
                    Paduan curr = new Paduan();
                    curr.Name = user;
                    curr.Side = forceSide;

                    if (!sides.ContainsKey(forceSide))
                    {
                        sides.Add(forceSide, new List<string>());
                    }
                    if (!sides[forceSide].Any(x => x == user))
                    {
                        sides[forceSide].Add(user);
                    }
                }
                else if (input.Contains(" -> "))
                {
                    string[] args = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = args[1];
                    string user = args[0];
                    //Paduan curr = new Paduan();
                    //curr.Name = user;
                    // curr.Side = forceSide;

                    if (!sides.ContainsKey(forceSide))
                    {
                        sides.Add(forceSide, new List<string>());
                    }
                    else
                    {
                        if (sides.Values.Any(s=>s.Contains(user)))
                        {
                            var sa = sides.Values.First(x => x.Contains(user));
                            sa.Remove(user);
                        }
                        //   Paduan curr = new Paduan();
                        //curr.Name = user;
                        // curr.Side = forceSide;
                        sides[forceSide].Add(user);
                        Console.WriteLine($"{user} joins the {forceSide} side!");
                    }
                }
            }

            var dist = sides.OrderBy(x => x.Value.Count)
                .ThenBy(x => x.Key);

            foreach (var item in dist.Where(x=>x.Value.Count!=0))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                foreach (var pad in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {pad}");
                }
            }

        }
    }
}
