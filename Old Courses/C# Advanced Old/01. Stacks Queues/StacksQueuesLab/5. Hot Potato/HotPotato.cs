using System;
using System.Collections.Generic;

/// <summary>
/// Remove every N (tossCount) element from the queue.
/// https://judge.softuni.bg/Contests/Practice/Index/925#5
/// </summary>

namespace _5._Hot_Potato
{
    class HotPotato
    {
        static void Main()
        {
            string[]children=Console.ReadLine().Split();
            int tossCount=int.Parse(Console.ReadLine());

            Queue<string>hotPotato=new Queue<string>(children);

            while (hotPotato.Count>1)
            {
                for (int i = 1; i < tossCount; i++)
                {
                    //Move element to the back of the queue.
                    hotPotato.Enqueue(hotPotato.Dequeue());
                }

                //Remove first element.
                Console.WriteLine("Removed {0}",hotPotato.Dequeue());
            }

            Console.WriteLine("Last is {0}",hotPotato.Dequeue());
        }
    }
}
