using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backToThePast
{
    class backtoThePast
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var age = 17;

            for (int i = 1800; i <= year; i++)
            {
                if (i%2==0)
                {
                    age++;
                    money -= 12000;
                }
                else
                {
                    age++;
                    money-=12000 + (50 * age);
                }
            }
            if (money>=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left." , money);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive." , Math.Abs(money));
            }
        }
    }
}
