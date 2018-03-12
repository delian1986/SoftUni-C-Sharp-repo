using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 22/100
/// </summary>

namespace _11._Poisonous_Plants
{
    class PoisonousPlants
    {
        static void Main()
        {
            int numOfPlants = int.Parse(Console.ReadLine());
            List<int> plants = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 1;

            while (true)
            {
                for (int i = 1; i < plants.Count; i++)
                {
                    int plantA = plants[i - 1];
                    int plantB = plants[i];

                    if (plantA < plantB)
                    {
                        plantB = -1;
                    }
                }

                if (plants.Contains(-1))
                {
                    plants.RemoveAll(x => x == -1);
                    count++;
                }
                else
                {
                    count++;
                    break;
                }
            }

            Console.WriteLine(count);

        }
    }
}
