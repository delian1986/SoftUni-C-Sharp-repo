using System;
using System.Linq;
//Task 02:
//Write a program that reads two integer arrays of size N 
//from the console and compares them element by element.

namespace CompareArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1= new int[n];
            int[] arr2 = new int[n] ;

            for (int i = 0; i <arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            if (arr1.SequenceEqual(arr2))
            {
                var res = "Equal";
                Console.WriteLine(res);

            }
            else
            {
                var res = "Not equal";
                Console.WriteLine(res);
            }
        }
    }
}
