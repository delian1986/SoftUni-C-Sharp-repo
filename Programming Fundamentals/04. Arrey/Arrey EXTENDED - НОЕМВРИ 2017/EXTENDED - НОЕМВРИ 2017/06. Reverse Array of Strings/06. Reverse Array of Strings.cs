using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string items = Console.ReadLine();
            string[] itemsArray = items.Split (' ');

            var first = itemsArray[0];

            for (int i = 0; i < itemsArray.Length; i++)
            {
                itemsArray[0] = itemsArray[itemsArray.Length-1];
                itemsArray[itemsArray.Length-1] = first;
                Console.WriteLine(itemsArray[i]);

            }
        }
    }
}
