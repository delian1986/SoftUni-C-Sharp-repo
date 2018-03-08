using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Reverse string using Stack.
/// https://judge.softuni.bg/Contests/Practice/Index/925#0
/// </summary>
namespace _1._Reverse_Strings
{
    class Reverse
    {
        static void Main()
        {
            string input= Console.ReadLine();
            Stack<char> word = new Stack<char>();

            //Populating stack.
            foreach (var symb in input)
            {
                word.Push(symb);
            }

            //Printing the result.
            while (word.Count>0)
            {
                Console.Write(word.Pop().ToString());
            }

            Console.WriteLine();
        }
    }
}
