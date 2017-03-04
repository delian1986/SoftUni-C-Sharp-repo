using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var prevSum = 0;
            var currSum = 0;
            var diff = 0;
            var maxDiff = 0;
            for (int i = 0; i < n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());

                prevSum = currSum;
                currSum = 0;
                currSum += num1;
                currSum += num2;
                if (i!=0)
                {
                    diff = Math.Abs(prevSum - currSum);
                    if (diff>maxDiff)
                    {
                        maxDiff = diff;
                    }
                }

            }
            if (prevSum==currSum||n==1)
            {
                Console.WriteLine("Yes, value= " + currSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff= " + maxDiff);
            }
           
        }
    }
}
