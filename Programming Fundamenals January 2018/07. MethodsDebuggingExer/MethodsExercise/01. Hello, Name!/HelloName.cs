using System;

namespace _01._Hello__Name_
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();

            GreetingByName(name);
        }

        private static void GreetingByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
