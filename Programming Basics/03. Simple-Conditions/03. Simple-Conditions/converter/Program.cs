using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var singleDigit= number / 100 % 10;
            var tensDigits= number/10; 
            if (number ==1)
            {
                digit = "one";
            }
            else if (number == 2)
            {
                digit = "two";
            }
            else if (number == 3)
            {
                digit = "three";
            }
            else if (number == 4)
            {
                digit = "four";
            }
            else if (number == 5)
            {
                digit = "five";
            }
            else if (number == 6)
            {
                digit = "six";
            }
            else if (number == 7)
            {
                digit = "seven";
            }
            else if (number == 8)
            {
                digit = "eight";
            }
            else if (number == 9)
            {
                digit = "nine";
            }
            else
            {
                digit = "fail";
            }
            Console.WriteLine(digit);
        }
    }
}
