using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();

            myList.RemoveAll(x => x<0);

            if (myList.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            else if (myList.Count==1&&myList[0]==0)
            {
                Console.WriteLine("zero");
                return;
            }
            myList.Reverse();

            Console.WriteLine(string.Join(" ",myList));



        }
    }
}
