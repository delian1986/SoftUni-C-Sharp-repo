using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = 1;
            // for (int i = k; k <=n; i++)
            // {
            //     Console.WriteLine(k);
            //     k = 2 * k + 1;
            // }
            while (k<=n)
            {
                Console.WriteLine(k);
                k = 2*k + 1;
            }
        }
    }
}
