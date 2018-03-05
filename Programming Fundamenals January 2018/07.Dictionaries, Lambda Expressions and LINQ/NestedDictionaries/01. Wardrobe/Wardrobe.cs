using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// So, you’ll need to find something to wear.
/// https://judge.softuni.bg/Contests/Practice/Index/433#0
/// 100/100
/// </summary>

namespace _01._Wardrobe
{
    class Wardrobe
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dressRoom = new Dictionary<string, Dictionary<string, int>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { " -> ", ",", }, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                List<string> dresses = input.Skip(1).ToList();

                foreach (var dress in dresses)
                {
                    if (!dressRoom.ContainsKey(color))
                    {
                        dressRoom.Add(color, new Dictionary<string, int>());
                    }
                    if (!dressRoom[color].ContainsKey(dress))
                    {
                        dressRoom[color].Add(dress, 0);
                    }
                    dressRoom[color][dress]++;
                }
            }

            string[] query = Console.ReadLine().Split();
            string queryColor = query[0];
            string queryDress = query[1];

            foreach (var color in dressRoom)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var dress in color.Value)
                {
                    string found = string.Empty;

                    if (color.Key == queryColor && dress.Key == queryDress)
                    {
                        found = " (found!)";
                    }

                    Console.WriteLine($"* {dress.Key} - {dress.Value}{found}");
                }
            }
        }
    }
}
