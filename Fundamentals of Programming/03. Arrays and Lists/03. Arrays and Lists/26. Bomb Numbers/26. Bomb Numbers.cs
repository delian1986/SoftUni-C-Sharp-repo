using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombList = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < myList.Count; i++)
            {
                if (bombList[0] == myList[i])
                {
                    myList.Remove(myList[i]);

                    myList.RemoveRange(i,myList[i]-bombList[1]);

                }


            }
            Console.WriteLine(myList.Sum());


        }
    }
}
