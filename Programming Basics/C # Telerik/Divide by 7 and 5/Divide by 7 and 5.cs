using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string res;
            if (num % 7 == 0 && num % 5 == 0)
            {
                res = "true";
            }
            else
            {
                res = "false";
            }
            Console.WriteLine("{0} {1}",res,num);
        }
    }
}
