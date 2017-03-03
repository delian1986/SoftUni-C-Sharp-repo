using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holyDays = int.Parse(Console.ReadLine());
            int homeTown = int.Parse(Console.ReadLine());
            int weekends = 48;
            int weekendsInSofia = 48 - homeTown;
            if (year == "leap")
            {
                double playVolleyInSofia = weekendsInSofia * 3.0 / 4;
                double playVolleyCelebration = holyDays * 2.0 / 3;
                double totalPlay = playVolleyCelebration + playVolleyInSofia + homeTown;
                double percent = totalPlay * 0.15;
                double totalPlayVolley = totalPlay + percent;

                Console.WriteLine(Math.Truncate(totalPlayVolley));
            }
            else if (year == "normal")
            {
                double playVolleyInSofia = weekendsInSofia * 3.0 / 4;
                double playVolleyCelebration = holyDays * 2.0 / 3;
                double totalPlay = playVolleyCelebration + playVolleyInSofia + homeTown;

                Console.WriteLine(Math.Truncate(totalPlay));
            }

        }
    }
}
