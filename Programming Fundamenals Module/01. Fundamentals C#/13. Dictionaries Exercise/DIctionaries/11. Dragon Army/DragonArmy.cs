using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._Dragon_Army
{
    class DragonArmy
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<int>>> dragonArmy = new Dictionary<string, Dictionary<string, List<int>>>();

            int numOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfDragons; i++)
            {
                string[] dragon = Console.ReadLine().Split();
                string type = dragon[0];
                string name = dragon[1];
                List<int> stats = new List<int>();

                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy.Add(type, new Dictionary<string, List<int>>());
                }
                if (!dragonArmy[type].ContainsKey(name))
                {
                    dragonArmy[type].Add(name, new List<int>());
                }
                
                for (int j = 2; j < dragon.Length; j++)
                {
                    int damage = 45;
                    int health = 250;
                    int armor = 10;

                    if (j == 2)
                    {
                        if (dragon[2] == "null")
                        {
                            stats.Add(damage);

                        }
                        else
                        {
                            stats.Add(int.Parse(dragon[j]));
                        }
                    }
                    else if (j == 3)
                    {
                        if (dragon[3] == "null")
                        {

                            stats.Add(health);
                        }
                        else
                        {
                            stats.Add(int.Parse(dragon[j]));
                        }
                    }
                    else if (j == 4)
                    {
                        if (dragon[4] == "null")
                        {
                            stats.Add(armor);
                        }
                        else
                        {
                            stats.Add(int.Parse(dragon[j]));
                        }
                    }
                }
                dragonArmy[type][name]=stats;
            }

            foreach (var type in dragonArmy)
            {
                string dragonName = string.Empty;
                int damage = 0;
                int health = 0;
                int armor = 0;
                double sumOfDmg = 0d;
                double sumOfHealth = 0d;
                double sumOFArmor = 0d;
                int count = 0;


                List<string> listOfDragons = new List<string>();
                foreach (var name in type.Value.OrderBy(x => x.Key))
                {
                    var dragonStat = name.Value;
                    count++;

                    dragonName = name.Key;
                    damage = dragonStat[0];
                    health = dragonStat[1];
                    armor = dragonStat[2];

                    sumOfDmg += damage;
                    sumOfHealth += health;
                    sumOFArmor += armor;

                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append($"-{dragonName} -> damage: {damage}, health: {health}, armor: {armor}");
                    listOfDragons.Add(stringBuilder.ToString());

                    
                }
                Console.Write($"{type.Key}::");
                Console.WriteLine($"({(sumOfDmg / count):f2}/{(sumOfHealth / count):f2}/{(sumOFArmor / count):f2})");

                foreach (var row in listOfDragons)
                {
                    Console.WriteLine(row);
                }
            }
        }
    }
}
