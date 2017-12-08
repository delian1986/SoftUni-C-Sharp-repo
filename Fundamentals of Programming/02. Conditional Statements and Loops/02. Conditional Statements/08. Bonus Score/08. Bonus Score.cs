using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            var result = 0.0;

            if (score<=100)
            {
                result += 5;
            }
            else if (score>100 && score<1000)
            {
                result += (score * 0.2);
            }
            else if (score>=1000)
            {
                result += (score * 0.1);
            }

            if (score % 2 == 0)
            {
                result++;
            }
            else if (score % 10 == 5)
            {
                result += 2;
            }

            Console.WriteLine(result);
            Console.WriteLine(result+score);
        }
    }
}
