using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length - 1];


            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                while (condensed.Length != 1)
                {
                    condensed = new int[nums.Length - 1];

                    for (int i = 0; i < nums.Length - 1; i++)
                    {
                        condensed[i] = nums[i] + nums[i + 1];
                    }

                    nums = condensed;
                }
                Console.WriteLine(condensed[0]);
            }

        }
    }
}
