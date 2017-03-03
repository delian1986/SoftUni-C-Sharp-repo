using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_N._._._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var end = 1;

            while (n>=1)
            {
                Console.WriteLine(n);
                n -= 1;
            }
        }
    }
}
