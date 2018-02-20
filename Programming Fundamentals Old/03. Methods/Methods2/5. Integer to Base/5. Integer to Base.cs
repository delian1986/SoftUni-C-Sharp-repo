using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            var neededBase = int.Parse(Console.ReadLine());

            CalculateIntToBase(num,neededBase);
        }

        static void CalculateIntToBase(long num, int neededBase)
        {
            string res = String.Empty;
            while (num>0)
            {
                var remind = num % neededBase;
                num = num / neededBase;
                res = remind + res;

            }
            Console.WriteLine(res);

        }
    }
}
