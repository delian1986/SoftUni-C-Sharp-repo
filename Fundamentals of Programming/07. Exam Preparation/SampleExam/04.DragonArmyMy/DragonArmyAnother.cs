using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DragonArmyAnother
{
    static void Main(string[] args)
    {
        int numbeOfDragons = int.Parse(Console.ReadLine());

        Dictionary<string, SortedDictionary<string, List<int>>> dragonArmy = new Dictionary<string, SortedDictionary<string, List<int>>>();
        List<int> dragonStats = new List<int>();

        dragonArmy = DragonArmy(numbeOfDragons, dragonArmy);

        foreach (var type in dragonArmy)
        {
            var dmgSum = type.Value;
            var avrDmg = new List<int>();
            var avrHealth = new List<int>();
            var avrArmor = new List<int>();

            foreach (var stat in type.Value)
            {
                avrDmg.Add(stat.Value[0]);
                avrHealth.Add(stat.Value[1]);
                avrArmor.Add(stat.Value[2]);
            }

            Console.WriteLine($"{type.Key}::({avrDmg.Average():f2}/{avrHealth.Average():f2}/{avrArmor.Average():f2})");
            foreach (var dragonName in type.Value)
            {
                string[] stats = string.Join(" ", dragonName.Value).Split();
                Console.WriteLine($"-{dragonName.Key} -> damage: {stats[0]}, health: {stats[1]}, armor: {stats[2]}");

            }
        }
    }

    private static Dictionary<string, SortedDictionary<string, List<int>>> DragonArmy(int numbeOfDragons, Dictionary<string, SortedDictionary<string, List<int>>> dragonArmy)
    {
        for (int i = 0; i < numbeOfDragons; i++)
        {
            string[] dragonStatsInput = Console.ReadLine().Split();
            string type, name;
            int damage, health, armor;
            Stats(dragonStatsInput, out type, out name, out damage, out health, out armor);
            dragonArmy = PopulatingDict(dragonArmy, type, name, damage, health, armor);
        }

        return dragonArmy;
    }

    private static Dictionary<string, SortedDictionary<string, List<int>>> PopulatingDict(Dictionary<string, SortedDictionary<string, List<int>>> dragonArmy, string type, string name, int damage, int health, int armor)
    {
        if (!dragonArmy.ContainsKey(type))
        {
            dragonArmy[type] = new SortedDictionary<string, List<int>>();
        }

        if (!dragonArmy[type].ContainsKey(name))
        {
            dragonArmy[type].Add(name, new List<int>() {damage,health,armor });

        }
        else
        {
            dragonArmy[type][name][0]= damage;
            dragonArmy[type][name][1] = health;
            dragonArmy[type][name][2] = armor;

        }

        return dragonArmy;
    }


    private static void Stats(string[] dragonStatsInput, out string type, out string name, out int damage, out int health, out int armor)
    {
        type = dragonStatsInput[0];
        name = dragonStatsInput[1];
        damage = ParseDamage(dragonStatsInput);
        health = ParseHealth(dragonStatsInput);
        armor = ParseArmor(dragonStatsInput);
    }

    private static int ParseArmor(string[] dragonStatsInput)
    {
        int armor;
        if (dragonStatsInput[4] == "null")
        {
            armor = 10;
        }
        else
        {
            armor = int.Parse(dragonStatsInput[4]);
        }
        return armor;
    }

    private static int ParseHealth(string[] dragonStatsInput)
    {
        int health;
        if (dragonStatsInput[3] == "null")
        {
            health = 250;
        }
        else
        {
            health = int.Parse(dragonStatsInput[3]);
        }
        return health;
    }

    private static int ParseDamage(string[] dragonStatsInput)
    {
        int damage;
        if (dragonStatsInput[2] == "null")
        {
            damage = 45;
        }
        else
        {
            damage = int.Parse(dragonStatsInput[2]);
        }

        return damage;
    }
}
