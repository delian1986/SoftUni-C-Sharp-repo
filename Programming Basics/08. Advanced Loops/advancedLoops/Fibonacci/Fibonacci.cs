using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;

            if (n<2&&n>=0)
            {
                Console.WriteLine("1");
            }
            else
            {
                var fist = 1;
                var sec = 1;
                for (int i = 2; i <= n; i++)
                {
                    int next = fist + sec;
                    fist = sec;
                    sec = next;
                }
                Console.WriteLine(sec);
            }
        }
    }
}
