using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = (Console.ReadLine());
            int[] outarry = Array.ConvertAll(nums.ToString().ToArray(), x => (int)x - 48);

            var evenSum = 0;

            var oddSum = 0;
            var res = GetSummOfEvenAndOdds(outarry, ref evenSum, ref oddSum);
            Console.WriteLine(res);
        }

        private static int GetSummOfEvenAndOdds(int[] outarry, ref int evenSum, ref int oddSum)
        {
            foreach (var item in outarry)
            {
                if (item<0)
                {
                    continue;
                }
                if (item % 2 == 0)
                {
                    evenSum += EvenSum(item);
                }
                else
                {

                    oddSum += OddSum(item);
                }
            }
            return evenSum * oddSum;
        }

        private static int OddSum(int item)
        {
            var sum = 0;
            return sum += Math.Abs(item);
        }

        private static int EvenSum(int item)
        {
            var sum = 0;
            return sum += Math.Abs(item);
        }
    }
}
