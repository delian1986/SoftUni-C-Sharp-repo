using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string frstName = Console.ReadLine();
            string scndName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {frstName} {scndName}. You are {age} years old." );
        }
    }
}
