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

            int compare = input.Length < input2.Length ? input.Length : input2.Length;
            var result = "=";

            for (int i = 0; i < compare; i++)
            {
                if (input[i]<input2[i])
                {
                    result = "<";
                    break;
                }
                if (input[i]>input2[i])
                {
                    result = ">";
                    break;
                }
            }

            if (result=="=")
            {
                if (input.Length>input2.Length)
                {
                    result = ">";
                }
                if (input.Length<input2.Length)
                {
                    result = "<";
                }
            }
            Console.WriteLine(result);
        }
    }
}