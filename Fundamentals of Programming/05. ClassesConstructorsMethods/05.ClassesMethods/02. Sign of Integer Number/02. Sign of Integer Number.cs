using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            DefineSign(num);

        }

        public static void DefineSign(int num)
        {
            string[] res = new string[]
            {
                "negative",
                "zero",
                "positive"
            };
            var getSign = num.CompareTo(0);
            var signnnn = res[getSign + 1];

            Console.WriteLine($"The number {num} is {signnnn}.");
        }
    }
}
