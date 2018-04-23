using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// </summary>

namespace _02._Drum_Set
{
    class Program
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = String.Empty;

            List<int> currentDrumsState = drums.ToList();

            while ((input=Console.ReadLine())!= "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i <currentDrumsState.Count; i++)
                {
                    currentDrumsState[i] -= hitPower;

                    if (currentDrumsState[i]<=0)
                    {
                        decimal drumCost = drums[i] * 3;
                        if (money>=drumCost)
                        {
                            currentDrumsState[i] = drums[i];
                            money -= drumCost;
                        }
                        else
                        {
                            currentDrumsState.RemoveAt(i);
                            drums.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ",currentDrumsState));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
