using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var leftSum = 0.0;
            var rightSum = 0.0;

            for (int i = 1; i <= num*2; i++)
            {
                double newNum = double.Parse(Console.ReadLine());

                
                    if (i>=1&&i<=num)
                {
                    leftSum += newNum;
                }
                else if (i>num&&i<=num*2)
                {
                    rightSum += newNum;
                }
            }


            if (leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
            double res = Math.Abs(leftSum -rightSum);
                Console.WriteLine($"No, diff = {res}");

            }
        }
    }
}
