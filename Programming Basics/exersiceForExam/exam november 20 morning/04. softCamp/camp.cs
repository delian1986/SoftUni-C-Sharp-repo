using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.softCamp
{
    class camp
    {
        static void Main(string[] args)
        {
            var grps = int.Parse(Console.ReadLine());
            decimal allPpl = 0;
            var car = 0;
            var van = 0;
            var smallBus = 0;
            var bigBus = 0;
            var train = 0;

            for (int i = 0; i < grps; i++)
            {
                int ppl = int.Parse(Console.ReadLine());
                allPpl += ppl;
                if (ppl > 0 && ppl <= 5)
                {
                    car += ppl;
                }
                else if (ppl >= 6 && ppl <= 12)
                {
                    van += ppl;
                }
                else if (ppl >= 13 && ppl <= 25)
                {
                    smallBus += ppl;
                }
                else if (ppl >= 26 && ppl <= 40)
                {
                    bigBus += ppl;
                }
                else
                {
                    train += ppl;
                }
            }
            Console.WriteLine("{0:f2}%", car / allPpl * 100);
            Console.WriteLine("{0:f2}%", van / allPpl * 100);
            Console.WriteLine("{0:f2}%", smallBus / allPpl * 100);
            Console.WriteLine("{0:f2}%", bigBus / allPpl * 100);
            Console.WriteLine("{0:f2}%", train / allPpl * 100);

        }
    }
}
