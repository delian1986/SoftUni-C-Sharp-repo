using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.List
{
    class list
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
            //myList.Add(20);
            //myList.Add(20);
            //myList.Add(22);
            //myList.Add(20);
            //myList.Add(20);
            string enter = Console.ReadLine();

            while (enter!="exit")
            {
                int number = int.Parse(enter);
                myList.Add(number);
                enter = Console.ReadLine();

            }
            
            Console.WriteLine(string.Join(" ",myList));
            
        }
    }
}
