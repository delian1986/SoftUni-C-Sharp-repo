using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Float_or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = decimal.Parse(Console.ReadLine());

            if (num%10==0)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(Math.Round(num));
            }
        }
    }
}
