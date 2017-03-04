using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in range [1..100]: ");
            var n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid Number!");
                Console.WriteLine("Enter a number in range [1..100]: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: " + n);

        }
    }
}
