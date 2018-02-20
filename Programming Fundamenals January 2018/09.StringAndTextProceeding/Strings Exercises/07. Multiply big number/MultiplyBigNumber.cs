using System;
using System.Linq;
using System.Text;

/// <summary>
/// This program multiply one big number with digit.
/// https://judge.softuni.bg/Contests/Compete/Index/321#6
/// </summary>

namespace _07._Multiply_big_number
{
    class MultiplyBigNumber
    {
        static void Main()
        {
            string numOne=Console.ReadLine();
            int numToMultily=int.Parse(Console.ReadLine());

            if (numToMultily==0)
            {
                Console.WriteLine(0);
                return;
            }

            int mutiplyer=0;
            int reminder=0;
            int num=0;
            StringBuilder sb=new StringBuilder();

            for (int i = numOne.Length - 1; i >= 0; i--)
            {
                mutiplyer=(numOne[i]-48)*numToMultily+reminder;

                num=mutiplyer%10;

                if (mutiplyer>9)
                {
                    reminder=mutiplyer/10;
                }
                else
                {
                    reminder=0;
                }
                sb.Append(num);
            }

            if (reminder>0)
            {
                sb.Append(reminder);
            }

            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray()
                .Reverse().ToArray());
        }
    }
}

