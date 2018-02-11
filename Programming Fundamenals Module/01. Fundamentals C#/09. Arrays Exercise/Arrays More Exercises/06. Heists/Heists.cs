using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int jewelPrice = sequence[0];
            int goldPrice = sequence[1];

            long totalEarnings = 0;
            long totalExpences = 0;

            string income = string.Empty;
            while ((income = Console.ReadLine()) != "Jail Time")
            {
                string[] materials = income.Split();
                string bounty = materials[0];
                int expences = int.Parse(materials[1]);

                int jewelCount = 0;
                int goldCount = 0;

                foreach (var item in bounty)
                {
                    if (item == '%')
                    {
                        jewelCount++;
                    }
                    else if (item == '$')
                    {
                        goldCount++;
                    }
                }
                totalEarnings += jewelCount * jewelPrice;
                totalEarnings += goldCount * goldPrice;

                totalExpences += expences;
            }

            long result =totalEarnings - totalExpences;

            if (result>= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {result}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(result)}.");
            }
        }
    }
}
