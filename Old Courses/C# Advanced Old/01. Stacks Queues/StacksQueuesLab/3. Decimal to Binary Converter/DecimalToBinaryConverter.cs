using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Convert decimal to binary using stack.
/// https://judge.softuni.bg/Contests/Practice/Index/925#2
/// </summary>

namespace _3._Decimal_to_Binary_Converter
{
    class DecimalToBinaryConverter
    {
        static void Main()
        {
            int decimalNum = int.Parse(Console.ReadLine());

            if (decimalNum==0)
            {
                Console.WriteLine(0);
                return;
            }
            Stack<int> binary = new Stack<int>();

            while (decimalNum > 0)
            {
                //we need the reminder.
                int reminder = decimalNum % 2;
                binary.Push(reminder);
                decimalNum /= 2;
            }

            while (binary.Count > 0)
            {
                Console.Write(binary.Pop());
            }
            Console.WriteLine();
        }
    }
}
