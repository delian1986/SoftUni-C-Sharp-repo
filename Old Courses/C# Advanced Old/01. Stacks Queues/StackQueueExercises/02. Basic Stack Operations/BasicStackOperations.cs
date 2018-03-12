using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/184#1
/// </summary>

namespace _02._Basic_Stack_Operations
{
    class BasicStackOperations
    {
        static void Main()
        {
            string[]args=Console.ReadLine().Split(new[]{" " },StringSplitOptions.RemoveEmptyEntries);

            Stack<string>sequence=new Stack<string>(Console.ReadLine().Split(new[]{ " "},StringSplitOptions.RemoveEmptyEntries));

            int numberElements=int.Parse(args[0]);
            int elementsToPop=int.Parse(args[1]);
            string lookFor=args[2];

            if (elementsToPop>sequence.Count)
            {
                elementsToPop=sequence.Count-1;
            }

            bool isFound=false;

            for (int i = 0; i < elementsToPop; i++)
            {
                sequence.Pop();
            }

            isFound=sequence.Contains(lookFor);

            if (sequence.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (!isFound||sequence.Count==0)
            {
                Console.WriteLine(sequence.Min());
            }
            else if(isFound)
            {
                Console.WriteLine("true");
            }
        }
    }
}
