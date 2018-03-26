using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/919#1
/// </summary>

namespace _02.RainbowDrops
{
    class RainBowDrops
    {
        static void Main()
        {
            string inputLine = String.Empty;

            SortedDictionary<double, string> rainbowDrop = new SortedDictionary<double, string>();

            int r, g, b;
            double vol;
            int counter = 0;

            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] colors = inputLine.Split().ToArray();

                if (colors.Length == 4)
                {
                    vol = double.Parse(colors[0]);
                    r = int.Parse(colors[1]);
                    g = int.Parse(colors[2]);
                    b = int.Parse(colors[3]);

                    if (r > 255 || r < 0) r = 0;
                    if (g > 255 || g < 0) g = 0;
                    if (b > 255 || b < 0) b = 0;
                }
                else
                {
                    continue;
                }

                if ((r < 100 && g < 100 && b > 200) || (r < 100 && g > 200 && b < 100) || (r > 200 && g < 100 && b < 100))
                {
                    if (!rainbowDrop.ContainsKey(vol))
                    {
                        rainbowDrop.Add(vol, $" V:{vol:F2} -> R:{r} G:{g} B:{b}");
                    }
                }
            }
            Console.WriteLine($"Rainbow Raindrops: {rainbowDrop.Count}");
            foreach (var color in rainbowDrop)
            {
                counter++;
                Console.WriteLine($"{counter}.{color.Value}");
            }
        }
    }
}
