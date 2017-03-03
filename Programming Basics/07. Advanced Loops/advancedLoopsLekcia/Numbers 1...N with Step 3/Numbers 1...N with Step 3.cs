using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_1._._.N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 1;
            var num = int.Parse(Console.ReadLine());

            while (n<=num)
            {
                Console.WriteLine(n);
                n += 3;
            }
        }
    }
}
