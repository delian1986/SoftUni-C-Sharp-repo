using System;

namespace _07.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = int.Parse(Console.ReadLine());
            int val2 = int.Parse(Console.ReadLine());
            int val3 = int.Parse(Console.ReadLine());
            FindBiggestOfThree(val1, val2, val3);

        }
        private static void FindBiggestOfThree(int val1, int val2, int val3)
        {
            var bigger = Math.Max(val1, val2);
            var biggest = Math.Max(bigger, val3);

            Console.WriteLine(biggest);
        }
    }
}
