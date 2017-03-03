using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            var tera = decimal.Parse(Console.ReadLine());

            var TeraTobits = tera * 8796093022208m;
            Console.WriteLine($"{TeraTobits:f0}");
        }
    }
}
