using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Integer_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            uint b = uint.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            Console.WriteLine($"{a} {b} {c} {d}");
        }
    }
}
