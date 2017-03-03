using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onTimeForExam
{
    class onTimeForExam
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMin = int.Parse(Console.ReadLine());
            var arriveHour = int.Parse(Console.ReadLine());
            var arriveMin = int.Parse(Console.ReadLine());

            var hourExamToMin = examHour * 60;
            var hourArriveToMin = arriveHour * 60;

            var arriveResMin = hourArriveToMin + arriveMin;
            var examResMin = hourExamToMin + examMin;

            var result = arriveResMin - examResMin;

            var min = result % 60;
            var hours = result / 60;

            if (result == 0)
            {
                Console.WriteLine("On Time");
            }
            if (result > 0 && result < 60)
            {

                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", min);
            }
            if (result > 0 && result >= 60)
            {
                if (min >= 0 && min < 10)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:0{1} hours after the start", hours, min);
                    return;
                }
                else if (min > 9 && min < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1} hours after the start", hours, min);
                }
            }
            if (result >= -30 && result < 0)
            {
                min = min * -1;
                Console.WriteLine("On Time");
                Console.WriteLine("{0} minutes before the start", min);
            }
            if (result < -30&& result<0)
            {
                if (min < 0 && min > -10 && hours < 0)
                {
                    hours = hours * -1;
                    min = min * -1;
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:0{1} hours before the start", hours, min);
                }
                else if (hours < 0 && min < -9&&min <0)
                {

                    min = min * -1;
                    hours = hours * -1;
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1} hours before the start", hours, min);
                }
            }
            if (result < -30 && result > -60)
            {
                min = min * -1;
                hours = hours * -1;
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", min);
            }
            if (min <= 0 && min > -10)
            {
                min = min * -1;
                hours = hours * -1;
                Console.WriteLine("Early");
                Console.WriteLine("{0}:0{1} hours before the start", hours, min);
            }

        }
    }
}