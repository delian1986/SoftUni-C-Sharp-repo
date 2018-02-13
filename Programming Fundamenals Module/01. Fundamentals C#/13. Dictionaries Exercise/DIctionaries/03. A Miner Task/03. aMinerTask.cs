using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            string inputLine = String.Empty;

            Dictionary<string, int> bounty = new Dictionary<string, int>();
            string element = string.Empty;

            for (int i = 1; i < int.MaxValue; i++)
            {
                string material = Console.ReadLine();
                if (material=="stop")
                {
                    break;
                }
                if (i % 2 == 1)
                {
                    element=material;

                    if (!bounty.ContainsKey(material))
                    {
                        bounty.Add(material, 0);
                    }
                }
                else
                {
                    bounty[element] += int.Parse(material);
                }
            }

            foreach (var mat in bounty)
            {
                Console.WriteLine($"{mat.Key} -> {mat.Value}");
            }
        }
    }
}
