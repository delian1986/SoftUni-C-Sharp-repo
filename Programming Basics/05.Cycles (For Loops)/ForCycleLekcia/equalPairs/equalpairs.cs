using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstPair = 0;
            var nextPair = 0;
            var prevPair = 0;
            var diff = 0;
            var maxDiff = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    firstPair = num1 + num2;
                    prevPair = firstPair;
                }
                nextPair = num1+num2;
                diff = Math.Abs(prevPair - nextPair);
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
                 prevPair=nextPair;



            }
            if (maxDiff==0)
            {
                Console.WriteLine("Yes, value="+firstPair);
            }
            else
            {
                
                Console.WriteLine("no maxdiff="+maxDiff);
            }
        }
    }
}
