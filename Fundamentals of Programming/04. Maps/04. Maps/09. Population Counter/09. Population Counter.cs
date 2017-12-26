using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populationCounter = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                var text = input.Split('|');
                var country = text[1];
                var city = text[0];
                long pop = long.Parse(text[2]);

                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter.Add(country, new Dictionary<string, long>());

                }
                if (!populationCounter[country].ContainsKey(city))
                {
                    populationCounter[country][city] = pop;
                }


                input = Console.ReadLine();
            }

            foreach (var country in populationCounter.OrderByDescending(n =>n.Value.Values.Sum()))
            {
                    Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(c =>c.Value))
                {

                    Console.Write($"=>{city.Key}: ");
                    Console.WriteLine(city.Value);
                }
            }
        }
    }
}
