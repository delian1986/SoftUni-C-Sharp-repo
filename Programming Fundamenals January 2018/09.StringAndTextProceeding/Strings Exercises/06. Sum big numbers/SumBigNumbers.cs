using System;
using System.Linq;
using System.Text;

/// <summary>
/// This program sum two big numbers. All operations msut be done 
/// only with strings.
/// https://judge.softuni.bg/Contests/Compete/Index/321#5
/// </summary>

namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numOne = Console.ReadLine();
            string numTwo = Console.ReadLine();

            if (numOne.Length > numTwo.Length)
            {
                numTwo = numTwo.PadLeft(numOne.Length, '0');
            }
            else
            {
                numOne = numOne.PadLeft(numTwo.Length, '0');
            }

            int sum = 0;
            int reminder = 0;
            int num = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = numOne.Length - 1; i >= 0; i--)
            {
                sum = numOne[i] - 48 + numTwo[i] - 48+reminder;
                num = sum % 10;

                if (sum > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }

                sb.Append(num);

                if (i == 0 && reminder == 1)
                {
                    sb.Append(reminder);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
