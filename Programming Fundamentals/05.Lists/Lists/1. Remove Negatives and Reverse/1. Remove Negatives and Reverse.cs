using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
             List<int> result = new List<int> { };

            myList.RemoveAll(i => i < 0);
            myList.Reverse();

            if (myList.Count==0)
            {
                Console.WriteLine("empty");
                return;
            }

            Console.WriteLine(String.Join(" ", myList));
        }
    }
}
