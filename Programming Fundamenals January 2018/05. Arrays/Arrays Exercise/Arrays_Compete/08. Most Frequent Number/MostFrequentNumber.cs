using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]elements=Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] elements = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            //int[] elements = new int[] { 1, 1, 1, 2, 2, 2, 2, 4, 4 };
            //1  1  1  2  2  2  4  4
            int num=0;
            int totalOccur=0;

            for (int i = 0; i < elements.Length; i++)
            {
                int currNum=elements[i];
                int currOccur=0;
                for (int j = i; j < elements.Length; j++)
                {
                    if (elements[i]==elements[j])
                    {
                        currOccur++;
                        if (currOccur>totalOccur)
                        {
                            totalOccur=currOccur;
                            num=currNum;
                        }
                    }

                }
            }

            Console.WriteLine(num);

        }
    }
}
