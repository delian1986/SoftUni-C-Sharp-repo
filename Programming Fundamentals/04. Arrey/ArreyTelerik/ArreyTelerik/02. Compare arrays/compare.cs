using System;
using System.Linq;


//Task 02: Write a program that reads two integer arrays of size N
//from the console and compares them element by element.



namespace _02.Compare_arrays
{
    class compare
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int []arr1=new int [n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                 arr1=new int[int.Parse(Console.ReadLine())];
            }
            for (int i = 0; i < n; i++)
            {
                arr2 = new int[ int.Parse(Console.ReadLine()) ];
            }
            if (arr1.SequenceEqual(arr2))
            {
                string res = "Equal";
                Console.WriteLine(res);
            }
            else 
            {
                string res = "Not equal";
                Console.WriteLine(res);
            }



        }
    }
}