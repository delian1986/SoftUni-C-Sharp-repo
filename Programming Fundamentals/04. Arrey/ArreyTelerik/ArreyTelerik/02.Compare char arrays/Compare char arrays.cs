using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Task 03:
//Write a program that compares two char arrays 
//lexicographically (letter by letter).


namespace _02.Compare_char_arrays
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] first = new string[] { input };
            string[] second = new string[] { input2 };

            var res = String.Empty;

            if (first.Length==second.Length)
            {
                res = "=";
            }
            if (first.Length>second.Length)
            {
                res = ">";
            }
            if (first.Length<second.Length)
            {
                res = "<";

            }
            Console.WriteLine(res);
        }
    }
}
