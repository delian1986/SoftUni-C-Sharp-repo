using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
            int numToCheck=int.Parse(Console.ReadLine());
            CheckSignOfTheNumber(numToCheck);
        }

        private static void CheckSignOfTheNumber(int numToCheck)
        {
            if (numToCheck>0)
            {
                Console.WriteLine($"The number {numToCheck} is positive.");
            }
            else if (numToCheck<0)
            {
                Console.WriteLine($"The number {numToCheck} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
