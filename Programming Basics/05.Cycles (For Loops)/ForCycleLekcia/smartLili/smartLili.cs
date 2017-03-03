using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washPrice = decimal.Parse(Console.ReadLine());
            var toyPrice = decimal.Parse(Console.ReadLine());
            var money = 0;
            var present = 0;
            var toys = 0;
            var bro = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    present += 10;
                    money +=present;
                    bro++;
                }
                else
                {
                    toys++;
                }
            }
            var res = (toys * toyPrice)+(money-bro);
            if (res>=washPrice)
            {
                var a = res-washPrice;
                Console.WriteLine("Yes! {0:f2}",a);
            }
            else
            {

                var a = washPrice - res;
                Console.WriteLine("No! {0:f2}", a);

            }

        }
    }
}
