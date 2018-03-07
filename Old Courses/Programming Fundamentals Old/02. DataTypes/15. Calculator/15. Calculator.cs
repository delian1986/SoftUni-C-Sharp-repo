using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = 0;
            switch (sign)
            {
                case '+':
                    c = a + b;
                    Console.WriteLine($"{a} + {b} = {c}");
                    break;
                case '*':
                    c = a * b;
                    Console.WriteLine($"{a} * {b} = {c}");
                    break;
                case '-':
                    c = a - b;
                    Console.WriteLine($"{a} - {b} = {c}");
                    break;
                case '/':
                    c = a / b;
                    Console.WriteLine($"{a} / {b} = {c}");
                    break;
            }
        }
    }
}
