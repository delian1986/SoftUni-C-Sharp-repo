using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 70/100
/// </summary>

namespace _02._Snowmen
{
    class Snowmen
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (sequence.Count != 1)
            {
                List<int> lostElements = new List<int>();

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (Math.Abs(sequence.Count - lostElements.Count) == 1)
                    {
                        continue;
                    }
                    if (lostElements.Contains(i))
                    {
                        continue;
                    }

                    int attacker = i;
                    int target = sequence[i];
                    if (target > sequence.Count)
                    {
                        target %= sequence.Count;
                    }

                    int battle = Math.Abs(attacker - target);
                    if (battle == 0)
                    {
                        //snowman suicide..???
                        Console.WriteLine($"{attacker} performed harakiri");
                        lostElements.Add(attacker);
                        lostElements.Distinct().ToList();
                    }
                    else
                    {
                        if (battle % 2 == 0)
                        {
                            //attacker wins
                            lostElements.Add(target);

                            Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                            lostElements.Distinct().ToList();

                        }

                        else
                        {
                            //target wins
                            lostElements.Add(attacker);

                            Console.WriteLine($"{attacker} x {target} -> {target} wins");
                            lostElements.Distinct().ToList();

                        }
                    }
                }

                foreach (var item in lostElements.OrderByDescending(x => x).Distinct())
                {
                    sequence.RemoveAt(item);
                }
            }

        }
    }
}

