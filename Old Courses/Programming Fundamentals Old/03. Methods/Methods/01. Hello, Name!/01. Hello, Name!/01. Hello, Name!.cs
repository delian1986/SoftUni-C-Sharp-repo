using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            PrintName(name);
            Console.WriteLine($"Hello, {PrintName(name)}!");
        }

        private static string PrintName(string name)
        {
            return name;
        }
    }
}
