using System;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotate = int.Parse(Console.ReadLine());
            int[]result=new int[arr.Length];

            for (int i = 0; i <rotate; i++)
            {
                int last=arr[arr.Length-1];

                for (int j = arr.Length-1; j >0; j--)
                {
                    arr[j]=arr[j-1];
                    result[j]+=arr[j];
                }
                arr[0]=last;

                result[0]+=arr[0];

            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
