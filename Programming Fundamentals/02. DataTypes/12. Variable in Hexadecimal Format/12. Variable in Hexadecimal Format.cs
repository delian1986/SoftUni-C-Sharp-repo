using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var res = Convert.ToInt64(input, 16);
            Console.WriteLine(res);
        }
    }
}
