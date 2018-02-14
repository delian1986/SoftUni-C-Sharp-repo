using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Legendary_Farming
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> legendary = new Dictionary<string, int>()
            {
                {"motes",0},
                {"shards",0},
                {"fragments",0}

            };

            Dictionary<string, int> junk = new Dictionary<string, int>();
            string drops = string.Empty;
            string obtained = string.Empty;
            bool legendaryWepon = false;

            while (!legendaryWepon)
            {
                drops = Console.ReadLine().ToLower();
                string[] loot = drops.Split();

                for (int i = 0; i < loot.Length - 1; i += 2)
                {
                    if (loot[i + 1] == "motes" || loot[i + 1] == "shards" || loot[i + 1] == "fragments")
                    {
                        //if (!legendary.ContainsKey(loot[i + 1]))
                        //{
                        //    legendary.Add(loot[i + 1], 0);
                        //}
                        legendary[loot[i + 1]] += int.Parse(loot[i]);

                        if (legendary[loot[i + 1]] >= 250)
                        {
                            if (legendary["motes"] >= 250)
                            {
                                obtained = "Dragonwrath";
                                legendary["motes"] -= 250;
                                legendaryWepon = true;
                                break;
                            }
                            else if (legendary["shards"] >= 250)
                            {
                                obtained = "Shadowmourne";
                                legendary["shards"] -= 250;
                                legendaryWepon = true;
                                break;
                            }
                            else if (legendary["fragments"] >= 250)
                            {
                                obtained = "Valanyr";
                                legendary["fragments"] -= 250;
                                legendaryWepon = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(loot[i + 1]))
                        {
                            junk.Add(loot[i + 1], 0);
                        }
                        junk[loot[i + 1]] += int.Parse(loot[i]);
                    }
                }

            }
            Console.WriteLine($"{obtained} obtained!");

            foreach (var weapon in legendary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{weapon.Key}: {weapon.Value}");
            }

            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

            }
        }
    }
}
