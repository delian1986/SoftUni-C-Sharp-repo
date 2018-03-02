using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// 
/// </summary>

namespace _04._Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }
    }
    class Snowwhite
    {
        static void Main()
        {
            List<Dwarf>dwarfs=new List<Dwarf>();
            Dictionary<string,int>colorCount= new Dictionary<string, int>();
            string input=string.Empty;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] args = input.Split(new[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];
                string color = args[1];
                int physics = int.Parse(args[2]);

                var dwarf=dwarfs.SingleOrDefault(x=>x.Name==name&&x.Color==color);

                if (dwarf==null)
                {
                    dwarfs.Add(new Dwarf{Color=color,Name=name,Physics=physics });
                }
                else
                {
                    if (dwarf.Physics<physics)
                    {
                        dwarf.Physics=physics;
                    }
                }

                if (!colorCount.ContainsKey(color))
                {
                    colorCount.Add(color,0);
                }
                colorCount[color]++;

            }

            foreach (var dwarf in dwarfs.OrderByDescending(x=>x.Physics).ThenByDescending(x=>colorCount[x.Color]))
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}