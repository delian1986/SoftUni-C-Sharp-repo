using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            int[] arrayLine = new int[line];
            for (int i = 0; i < arrayLine.Length; i++)
            {
                int item = int.Parse(Console.ReadLine());
                arrayLine[i] = item;
            }

            for (int i = arrayLine.Length-1; i >=0 ; i--)
            {
                Console.Write($"{arrayLine[i]} ");
                if (i==line)
                {
                    Console.WriteLine();
                }
            }
            //Console.WriteLine();
            //for (int i= arrayLine.Length; i >=0; i--)
            //{
            //    Console.WriteLine(arrayLine[i]);
            //}
        }
    }
}
