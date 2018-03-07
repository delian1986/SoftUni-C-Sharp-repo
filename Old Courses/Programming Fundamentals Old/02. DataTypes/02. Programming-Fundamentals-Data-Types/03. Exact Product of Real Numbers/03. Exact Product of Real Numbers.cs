using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = decimal.Parse(Console.ReadLine());
            var res = 1m;

            for (decimal i = 1; i <=n; i++)
            {
                var num = decimal.Parse(Console.ReadLine());
                res *= num;
            }
            Console.WriteLine(res);
        }
    }
}
