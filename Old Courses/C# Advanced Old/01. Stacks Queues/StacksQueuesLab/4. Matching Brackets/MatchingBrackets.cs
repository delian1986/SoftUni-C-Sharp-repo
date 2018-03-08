using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Extract and print every sub-expression using stack. 
/// e.g. 1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5  -->
/// (2 + 3)
///(3 + 1)
///(2 - (2 + 3) * 4 / (3 + 1))
/// https://judge.softuni.bg/Contests/Practice/Index/925#3
/// </summary>

namespace _4._Matching_Brackets
{
    class MatchingBrackets
    {
        static void Main()
        {
            string sequence= Console.ReadLine();

            //We store indexes of all opening brackets.
            Stack<int>brackets= new Stack<int>();

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i]=='(')
                {
                    brackets.Push(i);
                }
                else if (sequence[i]==')')
                {
                    //If we find closing bracket we take substring
                    //between opening and closing brackets.
                    int openBracket=brackets.Pop();
                    string expression=sequence.Substring(openBracket,i-openBracket+1);
                    Console.WriteLine(expression);
                }
            }

        }
    }
}
