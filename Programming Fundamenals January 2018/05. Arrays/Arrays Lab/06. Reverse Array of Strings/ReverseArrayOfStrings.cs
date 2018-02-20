using System;
using System.Linq;

namespace _06._Reverse_Array_of_Strings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] symbols=Console.ReadLine().Split().ToArray();

            for (int i = symbols.Length - 1; i >= 0; i--)
            {
                Console.Write(symbols[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
