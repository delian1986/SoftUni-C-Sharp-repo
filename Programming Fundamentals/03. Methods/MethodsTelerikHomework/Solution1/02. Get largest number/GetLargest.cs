using System;


namespace _02.Get_largest_number
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            GetMax(num1, num2, num3);


        }

        private static void GetMax(int num1, int num2, int num3)
        {
            var bigger = Math.Max(num1, num2);
            var largest = Math.Max(bigger, num3);
            Console.WriteLine(largest);
        }
    }
}
