using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = command[0];
            int power = command[1];

            while (sequence.Contains(bomb))
            {
                int index = sequence.IndexOf(bomb);

                int startIndex = index - power;
                int endIndex = index + power;

                if (startIndex >= 0 && endIndex <= sequence.Count - 1)
                {
                    sequence = BombItems(sequence, startIndex, endIndex);
                }

                else if (startIndex < 0)
                {
                    startIndex = 0;
                    sequence = BombItems(sequence, startIndex, endIndex);
                }
                else if (endIndex > sequence.Count - 1)
                {
                    endIndex = sequence.Count - 1;
                    sequence = BombItems(sequence, startIndex, endIndex);

                }
            }

            Console.WriteLine(sequence.Sum());

        }

        private static List<int> BombItems(List<int> sequence, int startIndex, int endIndex)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                sequence[i] = 0;
            }
            return sequence;
        }
    }
}