using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = int.Parse(Console.ReadLine());
            int[] array = new int[nums];

            for (int i = 0; i <nums; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int j = array.Length-1; j >=0; j--)
            {
                Console.Write(array[j] + " ");
            }
        }
    }
}
