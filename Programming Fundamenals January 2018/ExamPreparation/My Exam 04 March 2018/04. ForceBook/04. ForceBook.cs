using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/962#1
/// </summary>

namespace _04
{

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

                    //If current user exist in database.
                    bool userExist = false;
                    //skip him.
                    if (sides.Values.Any(x => x.Contains(user)))
                    {
                        continue;
                    }

                    //If not, add him.
                    if (!userExist)
                    {
                        if (!sides.ContainsKey(forceSide) && userExist == false)
                        {
                            sides.Add(forceSide, new List<string>());
                        }
                        if (!sides[forceSide].Any(x => x == user))
                        {
                            sides[forceSide].Add(user);
                        }

                    }

                }
                else if (input.Contains(" -> "))
                {
                    string[] args = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = args[1];
                    string user = args[0];


                    if (!sides.ContainsKey(forceSide))
                    {
                        sides.Add(forceSide, new List<string>());
                    }

                    //If current user exist in current side.
                    if (sides.ContainsKey(forceSide) && sides[forceSide].Any(x => x == user))
                    {
                        continue;
                    }
                    //Find and remove current user from the list.
                    if (sides.Values.Any(s => s.Contains(user)))
                    {
                        var findAndRemoveTheUser = sides.Values.First(x => x.Contains(user));
                        findAndRemoveTheUser.Remove(user);
                    }

                    sides[forceSide].Add(user);
                    Console.WriteLine($"{user} joins the {forceSide} side!");
                }
            }


            var sortedStructure = sides
                .OrderByDescending(x => x.Value.Count)
                 .ThenBy(x => x.Key);

            foreach (var side in sortedStructure.Where(x => x.Value.Count != 0))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }

        }
    }
}




