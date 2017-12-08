using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
            var numer = 0;
            var prevNum = 0;
            bool found = false;

            for (int i = 0; i < nums.Length; i++)
            {
                numer = nums[i];
                for (int j = 1; j < nums.Length; j++)
                {

                    prevNum = nums[j];
                    if (i == j)
                    {
                        continue;
                    }

                    for (int k = 0; k < nums.Length; k++)
                    {
                        if (prevNum + numer == nums[k] && i < j)
                        {
                            found = true;
                            Console.WriteLine(($"{(numer)} + {(prevNum)} == {(nums[k])}"));
                        }

                    }

                }
            }

            if (!found)
            {
                Console.WriteLine("No");

            }
        }
    }
}

