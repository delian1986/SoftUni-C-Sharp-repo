using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string charName = Console.ReadLine();
            int currHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            PlayerNamePrinter(charName);
            HpVisualization(currHP, maxHP);
            EnergyVisualization(currEnergy, maxEnergy);
        }

        private static void PlayerNamePrinter(string charName)
        {
            Console.WriteLine($"Name: {charName}");
        }

        private static void EnergyVisualization(int currEnergy, int maxEnergy)
        {
            string currEnegryVisualization = new string('|', currEnergy + 1);
            string maxEnergyVisualization = new string('.', maxEnergy - currEnergy);

            Console.WriteLine("Energy: {0}", currEnegryVisualization + maxEnergyVisualization + "|");
        }

        private static void HpVisualization(int currHP, int maxHP)
        {
            string hpVisual = new string('|', currHP + 1);
            string maxHpVis = new string('.', maxHP - currHP);

            Console.WriteLine("Health: {0}", hpVisual + maxHpVis + "|");
        }
    }
}
