using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hops
{
    class Program
    {
        static void Main()
        {
            int[] sequence = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int numOfCommands = int.Parse(Console.ReadLine());
            int maxSum = 0;
            List<int> visitedPositons = new List<int>();
            visitedPositons.Add(0);

            for (int i = 0; i < numOfCommands; i++)
            {
                int[]moves=Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int sum = sequence[0];
                int bunnyPos = 0;
                for (int pos = 0; pos < moves.Length; pos++)
                {
                    bunnyPos +=  moves[pos];
                    if (bunnyPos>=sequence.Length||bunnyPos<0)
                    {
                        break;
                    }
                    if (visitedPositons.Contains(bunnyPos))
                    {
                        break;
                    }
                    visitedPositons.Add(bunnyPos);
                    //bunnyPos += args[pos];
                    sum += sequence[bunnyPos];
                }
                if (sum>maxSum)
                {
                    maxSum = sum;
                }

            }
            Console.WriteLine(maxSum);
        }
    }
}
