using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var summ = 0;
            var summ1 = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                summ = summ + num;


            }
            for (int i = 0; i < n; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                summ1 = summ1 + num2;
            }
            if (summ - summ1==0)
            {
                var res = "Yes, sum = ";
                Console.WriteLine(res+summ);
            }
            else
            {
                var res = "No, diff = ";
                Console.WriteLine(res+(Math.Abs(summ - summ1)));

            }
        }
    }
}

