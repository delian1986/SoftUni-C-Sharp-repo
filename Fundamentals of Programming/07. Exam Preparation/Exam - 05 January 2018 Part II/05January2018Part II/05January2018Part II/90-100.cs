using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05January2018Part_II
{
    class Dwarf
    {
        public string Name { get; set; }
        public string Hat { get; set; }
        public long Physics { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfArmy = new List<Dwarf>();
            dwarfArmy = ReadInput(dwarfArmy);
            ResultPrinter(dwarfArmy);
        }

        private static void ResultPrinter(List<Dwarf> dwarfArmy)
        {

            foreach (var dwarf in dwarfArmy.OrderByDescending(x=>x.Physics).ThenByDescending(x=>dwarfArmy.Count(y=>y.Hat==x.Hat)))
            {
                string hatColor = dwarf.Hat;
                string name = dwarf.Name;
                long physics = dwarf.Physics;

                Console.WriteLine($"({hatColor}) {name} <-> {physics}");
            }
        }

        private static List<Dwarf> ReadInput(List<Dwarf> dwarfArmy)
        {

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }
                string[] tokents = input.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = tokents[0].Trim();
                string dwarfHat = tokents[1].Trim();
                long dwarfPhysics = long.Parse(tokents[2].Trim());

                Dwarf newDwarf = new Dwarf
                {
                    Name = dwarfName,
                    Hat = dwarfHat,
                    Physics = dwarfPhysics
                };

                if (dwarfArmy.Any(x => x.Name == dwarfName) && dwarfArmy.Any(x => x.Hat == dwarfHat))
                {
                    var curr = dwarfArmy.FirstOrDefault(x => x.Name == dwarfName && x.Hat == dwarfHat);

                    if (curr.Physics > dwarfPhysics)
                    {
                        continue;
                    }
                    else
                    {
                        curr.Physics = dwarfPhysics;

                    }

                }

                else if (!dwarfArmy.Any(x => x.Name == dwarfName && dwarfArmy.Any(y => y.Hat == dwarfHat)))
                {
                    dwarfArmy.Add(newDwarf);
                    continue;
                }


            }
            return dwarfArmy;

        }

        
    }
}
