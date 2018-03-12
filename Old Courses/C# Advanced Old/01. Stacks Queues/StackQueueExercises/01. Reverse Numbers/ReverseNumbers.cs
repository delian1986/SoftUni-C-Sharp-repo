using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] sequence=Console.ReadLine().Split(new[]{" " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int>stack=new Stack<int>(sequence);

            while (stack.Count>0)
            {
                Console.Write(stack.Pop()+" ");
            }
            Console.WriteLine();
        }
    }
}
