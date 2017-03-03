using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTom
{
    class SleepyTom
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int playLimit = 30000;
            int workDays = (365 - daysOff);
            int playTimeWork = workDays * 63;
            int playTimeOff = daysOff * 127;
            int totalPlayTime = (playTimeWork + playTimeOff);

            if (playLimit > totalPlayTime)
            {
                Console.WriteLine("Tom sleeps well");
                int playHours = (playLimit - totalPlayTime) / 60;
                int playMin = (playLimit - totalPlayTime) % 60;
                Console.WriteLine("{0} hours and {1} minutes less for play", playHours, playMin);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                int playHours = (totalPlayTime - playLimit) / 60;
                int playMin = (totalPlayTime - playLimit) % 60;
                Console.WriteLine("{0} hours and {1} minutes more for play",playHours,playMin);

            }
        }
    }
}
