using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1;  num <= n;  num++)
            {
                var sum = 0;
                var dig = num;
                while (dig>0)
                {
                    sum += dig % 10;
                    dig = dig / 10;
                }
               
                var res = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{num} -> {res}");
            }
        }
    }
}
