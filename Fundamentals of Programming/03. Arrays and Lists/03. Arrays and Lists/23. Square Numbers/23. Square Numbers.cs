using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sqareList = new List<int>();

            for (int i = 0; i < myList.Count; i++)
            {
                if (Math.Sqrt(myList[i])==(int)Math.Sqrt(myList[i]))
                {
                    sqareList.Add(myList[i]);
                }

            }
            sqareList.Sort((x, y) => y.CompareTo(x));

            Console.WriteLine(string.Join(" ",sqareList));


        }
    }
}
