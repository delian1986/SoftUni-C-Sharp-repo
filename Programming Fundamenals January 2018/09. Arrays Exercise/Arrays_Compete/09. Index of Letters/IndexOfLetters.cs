using System;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string words=Console.ReadLine();

            foreach (char letter in words)
            {
                Console.WriteLine(letter+" -> "+(letter-97));
            }
        }
    }
}
