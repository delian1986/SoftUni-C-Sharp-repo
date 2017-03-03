using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            var digit = int.Parse(Console.ReadLine());

            int res = FindNthDigit(num, digit);
            Console.WriteLine(res);

        }

        public static int FindNthDigit(long num, int digit)
        {
            var count = 1;
            while (num>0)
            {
                
                if (count == digit)
                {
                    return (int)num % 10;
                }
                num /= 10;
                count++;
            }

           
            return (int)num%10;
        }
    }
}
