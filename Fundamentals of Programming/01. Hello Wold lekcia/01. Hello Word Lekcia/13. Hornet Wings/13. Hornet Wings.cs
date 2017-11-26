using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double dist = (n / 1000) * m;
            var flap = n / 100;
            var sec = (n / p) * 5;
            var res = sec + flap;
            Console.WriteLine($"{dist:f2} m.");
            Console.WriteLine($"{res} s.");

        }
    }
}
