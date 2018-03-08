using System;
using System.Collections.Generic;

/// <summary>
/// Make simple calculator with addition and subtraction using stack.
/// https://judge.softuni.bg/Contests/Practice/Index/925#1
/// </summary>


namespace _2._Simple_Calculator
{
    class SimpleCalculator
    {
        static void Main()
        {
            Stack<string>calculator= new Stack<string>();
            string[] input=Console.ReadLine().Split();

            //Populating Stack.
            for (int i = input.Length - 1; i >= 0; i--)
            {
                calculator.Push(input[i]);
            }


            while (calculator.Count>1)
            {
                //Left operand.
                int left=int.Parse(calculator.Pop());
                string operant=calculator.Pop();
                //Right operand.
                int right=int.Parse(calculator.Pop());

                switch (operant)
                {
                    case "+":
                        calculator.Push((left+right).ToString());
                        break;
                        case"-":
                        calculator.Push((left-right).ToString());
                        break;
                }
            }
                Console.WriteLine(calculator.Pop());
        }
    }
}
