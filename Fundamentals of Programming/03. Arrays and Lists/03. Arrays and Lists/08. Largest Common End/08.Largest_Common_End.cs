using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine().Split().ToList();
            List<string> otherList = Console.ReadLine().Split().ToList();

            var rightCount = 0;
            var leftCount = 0;

            for (int i = 0; i < firstList.Count && i < otherList.Count; i++)
            {
                if (firstList[i] == otherList[i])
                {
                    leftCount++;
                }
            }

            for (int j = 0; j < firstList.Count && j < otherList.Count; j++)
            {
                if (firstList[firstList.Count-1-j]==otherList[otherList.Count-1-j])
                {
                    rightCount++;
                }
            }


            var result = Math.Max(leftCount, rightCount);



            Console.WriteLine(result);
        }
    }
}
