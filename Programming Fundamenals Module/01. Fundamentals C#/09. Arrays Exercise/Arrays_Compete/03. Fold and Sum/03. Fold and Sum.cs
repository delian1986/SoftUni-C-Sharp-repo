using System;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = nums.Length / 4;

            int[] first = new int[k];
            int[] middle = new int[k * 2];
            int[] last = new int[k];

            first = PopulatingFirst(nums, k, first);
            middle = PopulatingMiddle(nums, k, middle);
            last = PopulatingLast(nums, k, last);

            int[]firstAndLast=JoiningFirstAndLast(first,last,k);

            int[]sumElements=SummAllElements(firstAndLast,middle,k);

            Console.WriteLine(string.Join(" ",sumElements));
        }

        private static int[] SummAllElements(int[] firstAndLast, int[] middle,int k)
        {
            int[]sumElements=new int[k*2];
            for (int i = 0; i < middle.Length; i++)
            {
                for (int j = i; j < firstAndLast.Length; j++)
                {
                    sumElements[i]=firstAndLast[j]+middle[i];
                    break;
                }
            }
            return sumElements;
        }

        private static int[] JoiningFirstAndLast(int[] first, int[] last,int k)
        {
            int[]firstAndLast=new int[k*2];
            int count=0;

            for (int i = 0; i < first.Length; i++)
            {
                firstAndLast[count]=first[i];
                count++;
            }

            for (int i = 0; i < last.Length; i++)
            {
                firstAndLast[count]=last[i];
                count++;
            }

            return firstAndLast;
        }

        private static int[] PopulatingLast(int[] nums, int k, int[] last)
        {
            int pos = 0;
            for (int i = k + (k * 2); i < nums.Length; i++)
            {
                last[pos] = nums[i];
                pos++;
            }

            last = last.Reverse().ToArray();
            return last;
        }

        private static int[] PopulatingMiddle(int[] nums, int k, int[] middle)
        {
            int pos = 0;
            for (int i = k; i < k + (k * 2); i++)
            {
                middle[pos] = nums[i];
                pos++;
            }

            return middle;
        }

        private static int[] PopulatingFirst(int[] nums, int k, int[] first)
        {
            for (int i = 0; i < k; i++)
            {
                first[i] = nums[i];
            }
            first = first.Reverse().ToArray();
            return first;
        }
    }
}
