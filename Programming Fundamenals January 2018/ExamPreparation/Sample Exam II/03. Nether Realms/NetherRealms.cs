using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/454#2
/// 100/100
/// </summary>

namespace _03._Nether_Realms
{
    class NetherRealms
    {
        static void Main()
        {
            string text = Console.ReadLine();

            //This is splitted deamons.
            string[] args = text.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string namePattern = @"[^0-9+\-*\/.,]";
            string dmgPattern=@"-?[\d]+\.?[\d]*";

            //We store name + health.
            SortedDictionary<string,int> deamonHealth=new SortedDictionary<string, int>();

            //We store name + damage.
            Dictionary<string,double>deamonDamage= new Dictionary<string, double>();

            for (int i = 0; i < args.Length; i++)
            {
                int health = 0;

                foreach (Match hp in Regex.Matches(args[i], namePattern))
                {
                    //Calculating health.
                    health += char.Parse(hp.Value);
                }

                //Populating health dict.
                deamonHealth[args[i]]=health;

                double damage=0.0;

                foreach (Match dmg in Regex.Matches(args[i],dmgPattern))
                {
                    //Calculating damage.
                    damage+=double.Parse(dmg.Value);
                }

                //Manipulating damage, where item is every char.
                foreach (var item in args[i])
                {
                    if (item=='*')
                    {
                        damage*=2;
                    }
                    else if (item=='/')
                    {
                        damage/=2;
                    }
                }
                //Populating damage dict.
                deamonDamage[args[i]]=damage;
            }

            foreach (var deamon in deamonHealth)
            {
                var name = deamon.Key;
                var hp=deamon.Value;
                var dmg=deamonDamage[deamon.Key];

                Console.WriteLine($"{name} - {hp} health, {dmg:f2} damage");
            }
        }
    }
}
