using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharStats_StringBuild
{
    class charStats_StringBuild
    {
        static void Main(string[] args)
        {
            string charName = Console.ReadLine();
            int currHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            PrintCharName(charName);
            HpVisualization(currHP, maxHP);
            EnergyViualization(currEnergy, maxEnergy);
        }

        private static void PrintCharName(string charName)
        {
            Console.WriteLine("Name: {0}",charName);
        }

        private static void EnergyViualization(int currEnergy, int maxEnergy)
        {
            StringBuilder energyVisualization = new StringBuilder();
            energyVisualization.Append("|");

            for (int i = 0; i < currEnergy; i++)
            {
                energyVisualization.Append("|");
            }

            for (int i = 0; i < maxEnergy-currEnergy; i++)
            {
                energyVisualization.Append(".");
            }
            energyVisualization.Append("|");

            Console.WriteLine("Energy: {0}",energyVisualization);
        }

        private static void HpVisualization(int currHP, int maxHP)
        {
            StringBuilder hpVisualization = new StringBuilder();
            hpVisualization.Append("|");

            for (int i = 0; i < currHP; i++)
            {
                hpVisualization.Append("|");
            }
            for (int i = 0; i < maxHP - currHP; i++)
            {
                hpVisualization.Append(".");
            }
            hpVisualization.Append("|");

            Console.WriteLine("Health: {0}",hpVisualization);
        }
    }
}
