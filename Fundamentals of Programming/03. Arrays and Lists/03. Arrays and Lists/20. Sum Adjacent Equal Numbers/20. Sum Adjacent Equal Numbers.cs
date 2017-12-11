using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> myList = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            for (int i = 0; i <myList.Count; i++)
            {
                if (i>=myList.Count-1)
                {
                    break;
                }

                else if (myList[i]==myList[i+1])
                {
                    myList[i] += myList[i];
                    myList.Remove(myList[i+1]);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ",myList));
        }
    }
}
