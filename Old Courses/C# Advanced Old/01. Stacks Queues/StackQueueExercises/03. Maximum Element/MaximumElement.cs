using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 75/100 
/// timeout on last 2 tests.
/// </summary>

namespace _03._Maximum_Element
{
    class MaximumElement
    {
        static void Main()
        {
            int queryCount = int.Parse(Console.ReadLine());
            Stack<int> sequence = new Stack<int>();
            Stack<int> max = new Stack<int>();
            int currMax = int.MinValue;

            for (int i = 0; i < queryCount; i++)
            {
                int[] args = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                switch (args[0])
                {
                    case 1:
                        int num = args[1];
                        sequence.Push(num);
                        if (num > currMax)
                        {
                            currMax = num;
                            max.Push(currMax);
                        }
                        break;
                    case 2:
                        int poped = sequence.Pop();
                        if (max.Count > 0 && poped == max.Peek())
                        {
                            max.Pop();
                            if (max.Count == 0)
                            {
                                currMax = int.MinValue;
                            }
                            else
                            {
                                currMax = max.Peek();
                            }
                        }
                        break;
                    case 3:
                        if (max.Count == 0)
                        {
                            Console.WriteLine(currMax);
                        }
                        else
                        {
                            Console.WriteLine(max.Pop());
                        }
                        break;
                }

            }
        }
    }
}
