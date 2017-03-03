using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string res;
            if (num % 2 == 0)
            {
                res = "even";
            }
            else
            {
                res = "odd";
            }
            Console.WriteLine("{0} {1}",res,num);

        }
    }
}
