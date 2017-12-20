using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Max_Sequence_of_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputLine = Console.ReadLine().Split().Select(long.Parse).ToArray();
            List<long> nums = new List<long>();
            List<long> temp = new List<long>();
            List<long> left = new List<long>();
            var count = 0;

            for (int i =0; i < inputLine.Length-1; i++)
            {
                if (inputLine[i]<inputLine[i+1])
                {
                    nums.Add(inputLine[i]);
                    nums.Add(inputLine[i + 1]);

                    if (nums.Count!=2)
                    {
                        nums.Remove(nums[i]);
                    }
                    if (count == 0)
                    {
                        left = nums;
                    }
                }
                else if (inputLine[i]>=inputLine[i+1])
                {
                    count++;
                    temp = nums;
                    nums = new List<long>();
                }
            }
        }
    }
}
