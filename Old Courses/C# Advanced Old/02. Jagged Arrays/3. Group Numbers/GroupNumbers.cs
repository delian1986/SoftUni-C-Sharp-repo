using System;
using System.Linq;

namespace _3._Group_Numbers
{
    class GroupNumbers
    {
        static void Main()
        {
            int[]sequence=Console.ReadLine().Split(new[]{", " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[]zero=sequence.Where(x=>Math.Abs(x)%3==0).ToArray();
            int[]one=sequence.Where(x=>Math.Abs(x)%3==1).ToArray();
            int[]two=sequence.Where(x=>Math.Abs(x)%3==2).ToArray();

            Console.WriteLine(string.Join(" ",zero));
            Console.WriteLine(string.Join(" ",one));
            Console.WriteLine(string.Join(" ",two));

        }
    }
}
