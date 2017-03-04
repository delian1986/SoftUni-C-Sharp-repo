using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backToThePast
{
    class backToThePast
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            var spendedMoney = 0.00M;
            var age = 17;
            for (int i = 1800; i <= year; i++)
            {
                age++;
                if (i%2==0)
                {
                    spendedMoney += 12000;
                    
                }
                else
                {
                    
                    spendedMoney += 12000+(age*50);
                }
            }
            var result = money - spendedMoney;
            if (result>=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",result );
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs(result));
            }
        }
    }
}
