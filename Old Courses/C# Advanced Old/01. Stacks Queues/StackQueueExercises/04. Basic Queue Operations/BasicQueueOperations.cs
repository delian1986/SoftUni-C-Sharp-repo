using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/184#3
/// </summary>

namespace _04._Basic_Queue_Operations
{
    class BasicQueueOperations
    {
        static void Main()
        {
            int[]args=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[]sequence=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numOfAllElements=args[0];
            int elementsToDequeue=args[1];
            int elementToFind=args[2];

            Queue<int>queue=new Queue<int>(sequence.Take(numOfAllElements));

            if (elementsToDequeue>queue.Count)
            {
                elementsToDequeue=queue.Count;
            }
            for (int i = 0; i < elementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
