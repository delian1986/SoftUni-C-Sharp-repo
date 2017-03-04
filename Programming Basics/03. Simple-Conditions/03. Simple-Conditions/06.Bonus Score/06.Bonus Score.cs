using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());

            var bonusScore = 0.00;
            if (score <= 100)
            {
                bonusScore = +5;
            }
            else if (score > 1000)
            {
                bonusScore = bonusScore + (score * 0.10);
            }
            else if (score > 100)
            {
                bonusScore = bonusScore + (score * 0.20);
                
            }


            if (score % 2 == 0)
            {
                bonusScore =bonusScore+ 1;
            }
            else if (score % 10 == 5)
            {
                bonusScore =bonusScore +2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(score + bonusScore);

        }
    }
}
