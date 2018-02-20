using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]elements=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diff=int.Parse(Console.ReadLine());
            int count=0;

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i; j < elements.Length; j++)
                {
                    if (Math.Abs(elements[i]-elements[j])==diff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

    }
}
