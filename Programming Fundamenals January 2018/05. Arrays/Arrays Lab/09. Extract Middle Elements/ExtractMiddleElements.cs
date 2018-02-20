using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] containerArr = new int[0];

            if (nums.Length == 1)
            {
                Console.WriteLine("{{ {0} }}", nums[0]);
                return;
            }
            else if (nums.Length % 2 == 0)
            {
                containerArr = new int[2];

                containerArr[0] = nums[nums.Length / 2 - 1];
                containerArr[1] = nums[nums.Length / 2];
            }
            else if (nums.Length % 2 != 0)
            {
                containerArr = new int[3];
                containerArr[0] = nums[nums.Length / 2 - 1];
                containerArr[1] = nums[nums.Length / 2];
                containerArr[2] = nums[nums.Length / 2 + 1];


            }
            Console.Write("{");
            Console.Write(string.Join(" ", containerArr));
            Console.WriteLine("}");
        }
    }
}
