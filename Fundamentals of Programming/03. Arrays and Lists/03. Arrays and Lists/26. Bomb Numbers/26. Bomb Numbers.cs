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
            int[] bombList = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bomb = bombList[0];
            var power = bombList[1];

            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] == bomb)
                {
                    var left = i - power;
                    var right = i + power;
                    if (left >= 0 && right <= myList.Count)
                    {
                        for (int j = left; j <= right; j++)
                        {
                            myList[j] = 0;
                        }
                    }
                    else if (left < 0 && right <= myList.Count)
                    {
                        for (int j = 0; j <= right; j++)
                        {
                            myList[j] = 0;

                        }
                    }
                    else if (left >= 0 && right > myList.Count)
                    {
                        for (int j = left; j <= myList.Count; j++)
                        {
                            myList[j] = 0;

                        }
                    }
                }
            }

            Console.WriteLine(myList.Sum());
        }



    }
}

