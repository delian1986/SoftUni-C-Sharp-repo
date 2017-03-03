using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (points<=100)
            {
                bonusPoints += 5;
            }
            if (points>1000)
            {
                bonusPoints = bonusPoints + points *0.20;
            }
            if (points>100)
            {
                bonusPoints = bonusPoints + points * 0.10;
            }

            if (points%2==0)
            {
                bonusPoints += 1;
            }
            if (points%10==5)
            {
                bonusPoints += 5;
            }
            Console.WriteLine("Bonus points:"+ bonusPoints);
            Console.WriteLine("Total Points :{0}", (points+bonusPoints));
        }
    }
}
