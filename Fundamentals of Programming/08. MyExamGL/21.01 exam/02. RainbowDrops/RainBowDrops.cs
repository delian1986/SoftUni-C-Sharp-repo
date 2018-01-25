using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RainbowDrops
{
    class RainBowDrops
    {
        static void Main(string[] args)
        {
            string inputLine = String.Empty;

            SortedDictionary<decimal, List<int>> rainbowDrop = new SortedDictionary<decimal, List<int>>();

            int counter = 0;

            int r,g, b;
            decimal vol;

            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] colors = inputLine.Split().ToArray();

                if (colors.Length == 4)
                {
                   vol = decimal.Parse(colors[0]);
                   r = int.Parse(colors[1]);
                   g = int.Parse(colors[2]);
                   b = int.Parse(colors[3]);

                    if (r > 255 || r < 0)
                    {
                        r = 0;
                    }
                    if (g > 255 || r < 0)
                    {
                        g = 0;
                    }
                    if (b > 255 || b < 0)
                    {
                        b = 0;
                    }
                }
                else
                {
                    continue;
                }


                rainbowDrop = PopulationColors(rainbowDrop, vol, r, g, b, counter);



            }
            Console.WriteLine($"Rainbow Raindrops: {rainbowDrop.Count}");
            foreach (var color in rainbowDrop.OrderBy(x => x.Key))
            {
                counter++;
                Console.WriteLine($"{counter}. V:{color.Key:f2} -> R:{color.Value[0]} G:{color.Value[1]} B:{color.Value[2]}");

            }

        }

        private static SortedDictionary<decimal, List<int>> PopulationColors(SortedDictionary<decimal, List<int>> rainbowDrop, decimal vol, int r, int g, int b, int counter)
        {
            if (r > 200 && g < 100 && b < 100 || g > 200 && r < 100 && b < 100 || b > 200 && r < 100 && g < 100)
            {
                List<int> colorsToAdd = new List<int>
                {
                    r,
                    g,
                    b
                };



                if (!rainbowDrop.ContainsKey(vol))
                {
                    rainbowDrop.Add(vol, new List<int>());
                }

                for (int i = 0; i < colorsToAdd.Count; i++)
                {
                    rainbowDrop[vol].Add(colorsToAdd[i]);
                }

            }
            return rainbowDrop;
        }
    }
}
