using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal mile = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{mile* 1.60934m:f2}");
        }
    }
}
