using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreyLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <=n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += i;
            }
            Console.WriteLine(sum);

        }
    }
}
