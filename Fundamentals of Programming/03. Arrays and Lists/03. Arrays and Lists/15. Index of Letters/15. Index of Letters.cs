using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            for (int c = 0; c < inputLine.Length; c++)
            {
                Console.WriteLine($"{inputLine[c]} -> {(int)inputLine[c]-97}");
        }
    }
}
}
