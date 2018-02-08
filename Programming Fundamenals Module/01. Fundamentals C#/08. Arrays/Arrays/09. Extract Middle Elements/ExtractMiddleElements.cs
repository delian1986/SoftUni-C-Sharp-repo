using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (nums.Length==1)
            {
                Console.WriteLine($"{ {nums[0]} }");
            }
        }
    }
}
