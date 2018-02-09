using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[]nums=Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numsToTake=nums[0];
            int numsToDelete=nums[1];
            int numToSearchFor=nums[2];

            sequence.Take(numsToTake);
            sequence.RemoveRange(0,numsToDelete);

            if (sequence.Contains(numToSearchFor))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
