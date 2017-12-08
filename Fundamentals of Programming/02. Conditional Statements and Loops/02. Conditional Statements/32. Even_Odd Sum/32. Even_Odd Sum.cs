using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Even_Odd_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= num; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    evenSum += newNum;
                }
                else
                {
                    oddSum += newNum;
                }
            }

            if (evenSum==oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");

            }
            else
            {
                int res = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {res}");

            }
        }
    }
}
