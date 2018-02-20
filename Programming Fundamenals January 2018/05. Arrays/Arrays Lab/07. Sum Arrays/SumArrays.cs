using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] someNums=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] otherNums=Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[]thirdArr=new int[Math.Max(someNums.Length,otherNums.Length)];

            for (int i = 0; i < Math.Max(someNums.Length,otherNums.Length); i++)
            {
                thirdArr[i]=someNums[i%someNums.Length]+otherNums[i%otherNums.Length];
            }

            Console.WriteLine(string.Join(" ",thirdArr));
        }
    }
}
