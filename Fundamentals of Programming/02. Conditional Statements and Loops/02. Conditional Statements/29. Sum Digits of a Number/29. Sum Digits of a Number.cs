using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Sum_Digits_of_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;


            for (int i = num; i >=0; i--)
            {
                sum += num % 10;
                num /= 10;
                if (num==0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
