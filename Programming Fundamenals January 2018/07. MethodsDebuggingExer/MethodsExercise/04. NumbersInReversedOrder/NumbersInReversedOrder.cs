using System;

namespace _04._NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string number=Console.ReadLine();
            string reversed=ReverseNum(number);
            Console.WriteLine(reversed);
        }

        private static string ReverseNum(string number)
        {
            string reversed=string.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed+=number[i];
            }
            return reversed;
        }
    }
}
