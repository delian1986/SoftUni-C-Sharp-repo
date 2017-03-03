using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.money
{
    class money
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());

            var sheetPaper = n * s;
            var reams = sheetPaper / 400M;
            var result = reams * p;
            Console.WriteLine("{0:F3}",result);

        }
    }
}
