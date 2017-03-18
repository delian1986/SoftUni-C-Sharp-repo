using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int neededDays = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            var daysToHours = neededDays * 24;
            var workHours = 8 * (neededDays - (neededDays * 0.10));
            var extendWork = workers * (2 * neededDays);
            var resHours = workHours + extendWork;

            if (resHours >= neededHours)
            {
                var res = Math.Floor(resHours - neededHours);
                Console.WriteLine("Yes!{0} hours left.", res);

            }
            else
            {
                var res = Math.Ceiling(neededHours - resHours);
                Console.WriteLine("Not enough time!{0} hours needed.", res);
            }
        }
    }
}
