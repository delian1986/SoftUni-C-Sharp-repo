using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomTheSleepyCat
{
    class TomTheSleepyCat
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            var workDays = 365 - restDays;
            var restPlayTime = restDays * 127;
            var workDaysPlayTime = workDays * 63; 
            var totalPlayHours = (workDays * 63)+(restDays*127);
            var playLimit = 30000;
            if (totalPlayHours>playLimit)
            {
                var playTime = totalPlayHours - playLimit;
                var playHours = playTime / 60;
                var playMin = playTime % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",playHours,playMin);
            }
            else
            {
                var playTime = playLimit - totalPlayHours;
                var playHours = playTime / 60;
                var playMin = playTime % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",playHours,playMin);
            }


        }
    }
}
