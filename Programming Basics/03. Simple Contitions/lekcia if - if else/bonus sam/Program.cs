using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_sam
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            var bonusPoints = 0;
            if (points <=100)
            {
                bonusPoints += 5;
            }
            if (points >1000)
            {
                bonusPoints = bonusPoints + points *20/100;
            }
            else if (points >100)
            {
                bonusPoints = bonusPoints + points * 10 / 100;
            }

            if (points %2 ==0)
            {
                bonusPoints += 1;
            }
            else if (points %10 ==5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine("Bonus: " +bonusPoints);
            Console.WriteLine("Total:{0}",points+bonusPoints);
        }
    }
}
