using System;
using System.Collections.Generic;

/// <summary>
/// Calculate sequence with queue.
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/184#4
/// </summary>

namespace _05._Sequence_With_Queue
{
    class SequenceWithQueue
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            Queue<decimal> sequence = new Queue<decimal>();
            int counter = 0;

            //Print first num. 
            Console.Write(n + " ");
            counter++;
            for (decimal i = 0; i < 50 / 3 + 1; i++)
            {
                //S1
                sequence.Enqueue(n + 1);
                Console.Write(n + 1 + " ");
                counter++;
                if (counter==50)
                {
                    //We need exaclly 50 numbers.
                    break;
                }

                //S2
                sequence.Enqueue(2 * n + 1);
                Console.Write(2 * n + 1 + " ");
                counter++;

                //S3
                sequence.Enqueue(n + 2);
                Console.Write(n + 2 + " ");
                counter++;

                //We dequeue and we start the calculation again.
                n = sequence.Dequeue();
            }
            Console.WriteLine();
        }
    }
}
