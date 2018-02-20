using System;


// Task 01: Write a program that allocates array of N integers, 
//initializes each element by its index multiplied by 5 and 
//the prints the obtained array on the console.


namespace _01.Allocate_array
{
    class allocate
    {
        static void Main(string[] args)
        {
            int[] n = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < n.Length; i++)
            {
                var multiplication = i * 5;
                Console.WriteLine(multiplication);
            }
        }
    }
}