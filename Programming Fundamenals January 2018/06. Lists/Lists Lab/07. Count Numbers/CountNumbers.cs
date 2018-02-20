using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Count_Numbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums= Console.ReadLine().Split().Select(int.Parse).ToList();

            nums.Sort();
            nums.Add(int.MaxValue);

            int counter=1;
            for (int i = 0; i < nums.Count-1; i++)
            {
                if (nums[i]==nums[i+1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine(nums[i]+" -> "+ counter);
                    counter=1;
                }
            }
        }
    }
}
