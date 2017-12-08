using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Numbers_from_20_to_2N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var num = 1;

            for (int i = 0; i <=n; i++)
            {
                Console.WriteLine(num);
                num *= 2;

            }
        }
    }
}
