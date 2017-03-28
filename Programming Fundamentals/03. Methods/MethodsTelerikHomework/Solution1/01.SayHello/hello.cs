using System;


namespace _01.SayHello
{
    class hello
    {
        static void Main()
        {
            var name = Console.ReadLine();

            PrintHelloName(name);
        }

        static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
