using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> myList = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i <myList.Count; i++)
            {
                if (i+1>=myList.Count)
                {
                    break;
                }
                if (myList[i]==myList[i+1])
                {
                    myList[i] = myList[i] + myList[i + 1];
                    myList.Remove(myList[i+1]);
                    i =-1;
                }
            }
            Console.WriteLine(string.Join(" ",myList));
        }
    }
}
