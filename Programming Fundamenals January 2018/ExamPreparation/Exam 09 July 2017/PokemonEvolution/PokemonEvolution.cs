using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/692#1
/// </summary>

namespace PokemonEvolution
{
    class Evolution
    {
        public string EvoType { get; set; }
        public int EvoIndex { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<Evolution>> pokemonz = new Dictionary<string, List<Evolution>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "wubbalubbadubdub")
            {
                string[] args = input.Split(new[]{ ' ','-','>'},StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];

                if (args.Length == 1)
                {
                    if (pokemonz.ContainsKey(name))
                    {
                        foreach (var pokemon in pokemonz.Where(x=>x.Key==name))
                        {
                            Console.WriteLine($"# {pokemon.Key}");
                            foreach (var item in pokemon.Value)
                            {
                            Console.WriteLine($"{item.EvoType} <-> {item.EvoIndex}");

                            }
                        }
                    }
                }
                else
                {
                    string evoType=args[1];
                    int evoIndex=int.Parse(args[2]);

                    if (!pokemonz.ContainsKey(name))
                    {
                        pokemonz.Add(name,new List<Evolution>());
                    }
                    Evolution newEvo=new Evolution{EvoIndex=evoIndex,EvoType=evoType};
                    pokemonz[name].Add(newEvo);
                }
            }

            foreach (var poke in pokemonz)
            {
                Console.WriteLine($"# {poke.Key}");

                foreach (var item in poke.Value.OrderByDescending(x=>x.EvoIndex))
                {
                    Console.WriteLine($"{item.EvoType} <-> {item.EvoIndex}");
                }
            }
        }
    }
}
