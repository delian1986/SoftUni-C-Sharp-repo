using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var num = 1;

            for (int i = 1; i <= n; i++)
            {
                num *= i;
            }
                Console.WriteLine(num);
        }
    }
}
