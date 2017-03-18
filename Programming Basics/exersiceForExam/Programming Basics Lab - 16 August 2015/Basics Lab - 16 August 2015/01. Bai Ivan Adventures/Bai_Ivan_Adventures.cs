using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Bai_Ivan_Adventures
{
    class Bai_Ivan_Adventures
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var money = decimal.Parse(Console.ReadLine());
            var litersWant = decimal.Parse(Console.ReadLine());

            var alchPrice = 0.0;
            string cond = string.Empty;
            decimal diff = 0;

            switch (day)
            {
                case 0:
                    alchPrice = 25;
                    break;
                case 1:
                    alchPrice = 21;
                    break;
                case 2:
                    alchPrice = 14;
                    break;
                case 3:
                    alchPrice = 17;
                    break;
                case 4:
                    alchPrice = 45;
                    break;
                case 5:
                    alchPrice = 59;
                    break;
                case 6:
                    alchPrice = 42;
                    break;
            }

            var litHave = money / (decimal) alchPrice;

            if (litHave > 1.5m)
            {
                cond = "very drunk";
            }
            else if (litHave<=1.5m&&litHave>=1m)
            {
                cond = "drunk";
            }
            else if (litHave<1m)
            {
                cond = "sober";
            }
            if (litHave<litersWant)
            {
                diff = litersWant - litHave;
                Console.WriteLine($"Bai Ivan is {cond} and quite sad. He wanted to drink another {diff:f2} l. of alcohol");
            }
            else if (litHave==litersWant)
            {
                Console.WriteLine($"Bai Ivan is {cond} and happy. He is as drunk as he wanted");
            }
            else
            {
                diff = litHave - litersWant;
                Console.WriteLine($"Bai Ivan is {cond} and very happy and he shared {diff:f2} l. of alcohol with his friends");
            }
        }
    }
}
