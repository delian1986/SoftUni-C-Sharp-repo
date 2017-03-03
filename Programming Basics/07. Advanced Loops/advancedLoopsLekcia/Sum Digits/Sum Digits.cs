using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var res = 0;
            do
            {
                res += n % 10;
                n = n / 10;

            } while (n != 0);

            Console.WriteLine(res);
        }
    }
}
