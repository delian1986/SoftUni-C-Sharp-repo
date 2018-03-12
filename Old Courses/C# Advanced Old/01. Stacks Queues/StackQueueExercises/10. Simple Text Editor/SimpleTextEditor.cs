using System;
using System.Collections.Generic;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/184#9
/// </summary>

class SimpleTextEditor
{
    static void Main()
    {
        string text = string.Empty;
        int numOfOperations = int.Parse(Console.ReadLine());
        Stack<string> lastOperation = new Stack<string>();
        lastOperation.Push(text);

        for (int i = 0; i < numOfOperations; i++)
        {
            string[] args = Console.ReadLine().Split();
            string command = args[0];
            string arg = string.Empty;

            switch (command)
            {
                case "1":
                    arg = args[1];
                    text += arg;
                    lastOperation.Push(text);
                    break;
                case "2":
                    arg = args[1];
                    int lastTwo = text.Length - int.Parse(arg);
                    text = text.Substring(0, lastTwo);
                    lastOperation.Push(text);
                    break;
                case "3":
                    arg = args[1];
                    int index = int.Parse(arg) - 1;
                    string returns = text[index].ToString();
                    Console.WriteLine(returns);
                    break;
                case "4":
                    if (lastOperation.Count > 1)
                    {
                        lastOperation.Pop();
                    }
                    text = lastOperation.Peek();
                    break;
            }

        }
    }
}
