using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int f0 = 0;
            int f1 = 1;
            int fRes = 0;
            if (n<2)
            {
                fRes = 1;

            }
            for (int i = 1; i<=n ; i++)
            {
                fRes = f0 + f1;
                f0=f1;
                f1=fRes;

            }
            Console.WriteLine(fRes);
        }
    }
}
