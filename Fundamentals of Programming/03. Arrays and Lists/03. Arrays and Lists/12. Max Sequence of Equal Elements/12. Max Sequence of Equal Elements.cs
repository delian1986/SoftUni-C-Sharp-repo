using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var count = 1;
            var res = 0;
            var max = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                    if (max < count)
                    {
                        max = count;
                        res = nums[i];

                    }
                }
                else if (nums[i] != nums[i + 1])
                {
                    count = 1;
                }

            }
            string print = string.Concat(Enumerable.Repeat($"{res} ", max));
            Console.WriteLine(print);
        }
    }
}
