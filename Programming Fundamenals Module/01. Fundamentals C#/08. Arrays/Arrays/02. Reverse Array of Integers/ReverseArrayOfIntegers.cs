using System;

namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            int[] nums=new int[num];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i]=int.Parse(Console.ReadLine());
            }

            for (int i = nums.Length-1; i >= 0; i--)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
