using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Population_Counter
{
    class PopulationCounter
    {
        static void Main()
        {
            string report=string.Empty;

            Dictionary<string,Dictionary<string,long>>popCounter= new Dictionary<string, Dictionary<string, long>>();

            while ((report=Console.ReadLine())!="report")
            {
                string[] tokens=report.Split('|').ToArray();
                string city=tokens[0];
                string country=tokens[1];
                long population=long.Parse(tokens[2]);

                if (!popCounter.ContainsKey(country))
                {
                    popCounter.Add(country,new Dictionary<string, long>());
                }
                popCounter[country].Add(city,population);
            }

            foreach (var country in popCounter.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
