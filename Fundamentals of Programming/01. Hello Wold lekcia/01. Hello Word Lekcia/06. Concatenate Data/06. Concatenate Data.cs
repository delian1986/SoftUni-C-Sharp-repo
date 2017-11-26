using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();


            Console.WriteLine($"You are {first} {last}, a {age}-years old person from {town}.");

        }
    }
}
