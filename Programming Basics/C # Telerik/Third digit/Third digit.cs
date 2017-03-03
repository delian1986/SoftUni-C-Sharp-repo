using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string res = "";
            var divi = num / 100 % 10;
            if (num/100%10==7)
            {
                res = "true";
                Console.WriteLine("{0}", res);

            }
            else
            {
                res = "false";
                Console.WriteLine("{0} {1}", res, divi);

            }

        }
    }
}
