using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = Console.ReadLine();
            var lastname = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are " + firstname + " "+ lastname + ", a " + age + "-years old person from " + town + ".");

        }
    }
}
