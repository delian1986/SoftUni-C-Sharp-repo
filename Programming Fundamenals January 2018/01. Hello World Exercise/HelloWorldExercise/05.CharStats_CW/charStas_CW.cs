using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharStats_CW
{
    class charStas_CW
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
            EnergyVisualization(currEnergy, maxEnergy);

        }

        private static void PrintCharName(string charName)
        {
            Console.WriteLine("Name: {0}",charName);
        }

        private static void EnergyVisualization(int currEnergy, int maxEnergy)
        {
            Console.Write("Energy: |");

            for (int i = 0; i < currEnergy; i++)
            {
                Console.Write("|");
            }

            for (int i = 0; i < maxEnergy-currEnergy; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
        }

        private static void HpVisualization(int currHP, int maxHP)
        {
            Console.Write("Health: ");
            for (int i = 0; i <= currHP; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < maxHP - currHP; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
        }
    }
}
