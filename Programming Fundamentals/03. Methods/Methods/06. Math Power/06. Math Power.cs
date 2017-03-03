using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var pow = int.Parse(Console.ReadLine());
            var res = NumToPow(n, pow);
            Console.WriteLine(res);
        }

        static double NumToPow(double n, int pow)
        {
            return Math.Pow(n, pow);
        }
    }
}
