using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var fact = 1;
            //var next = fact + 1;
            //var num = 2;
            //while (num<=n)
            //{
            //    fact = fact * next;
            //    next = num + 1;
            //    num += 1;
            //}
            //Console.WriteLine(fact);

            for (int i = 2; i <=n; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
