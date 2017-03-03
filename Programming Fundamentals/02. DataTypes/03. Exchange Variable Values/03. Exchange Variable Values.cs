using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var c = a+b;
            b = c-b;
            a = c-a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
