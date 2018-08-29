using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    class Program
    {
        static void Main()
        {
            int[]array=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index=0;
            int sum=Sum(array,index);

            Console.WriteLine(sum);
        }

        private static int Sum(int[] array, int index)
        {
            if (index==array.Length-1)
            {
                return array[index];
            }

            return array[index]+Sum(array,index+1);
        }
    }
}
