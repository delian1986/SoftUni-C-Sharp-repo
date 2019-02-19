using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main()
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                if (deck1.Count==0 ||deck2.Count==0)
                {
                    break;
                }

                if (deck1[0] > deck2[0])
                {
                    int losingCard = deck2[0];
                    int winningCard = deck1[0];
                    deck1.Add(winningCard);
                    deck1.Add(losingCard);
                    deck2.RemoveAt(0);
                    deck1.RemoveAt(0);
                }
                else if (deck1[0] < deck2[0])
                {
                    int losingCard = deck1[0];
                    int winningCard = deck2[0];
                    deck2.Add(winningCard);
                    deck2.Add(losingCard);
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
                else
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
            }

            if (deck1.Count>0)
            {
                Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");

            }
        }
    }
}
