using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

namespace _0._3_BigFActorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger res = 1;

            for (int i = 2; i <n; i++)
            {
                res *= i;
            }

            Console.WriteLine(res);

            File.WriteAllText("res.txt", $"Factorial {n} is = "+res.ToString());

            var file = new System.IO.StreamWriter("text.txt", true);
            file.WriteLine(res);
        }
    }
}
