using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartLili
{
    class smartLili
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washPrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var money = 0.0;
            var toys = 0;
            var even = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    even ++;
                    money += (10 * even)-1;
                }
                else
                {
                    toys++;
                }
            }
            var toysToMon = toys * toyPrice;
            var res = (toysToMon + money) - washPrice;
            var yn = "";
            if (res>=0)
            {
                yn = "Yes";
                Console.WriteLine("{0}! {1:f2}", yn, res);

            }
            else
            {
                yn = "No";
                Console.WriteLine("{0}! {1:f2}", yn, Math.Abs(res));

            }
        }
    }
}
