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

            var count = 0;
            if (firstList.Count == otherList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    for (int j = i; j < otherList.Count; j++)
                    {
                        if (firstList[i] == otherList[j])
                        {
                            count++;
                        }
                        break;
                    }
                }


            }
           
            Console.WriteLine(count);
        }
    }
}
