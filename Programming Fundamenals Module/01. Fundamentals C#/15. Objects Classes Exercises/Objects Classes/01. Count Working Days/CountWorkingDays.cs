using System;
using System.Globalization;
using System.Linq;

namespace _01._Count_Working_Days
{
    /// <summary>
    /// Count working days between two dates.
    /// https://judge.softuni.bg/Contests/Compete/Index/210#0
    /// </summary>
    class Program
    {
        static void Main()
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();
            //I parse the date to exact format.
            DateTime firstDate = DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime lastDate = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            //I add the official bulgarian holydays in array of DateTime.
            //I choose random leap year. Lets say 2004.
            DateTime[] holydays = new DateTime[]
            {
            new DateTime(4, 01, 01),
            new DateTime(4, 03, 03),
            new DateTime(4, 05, 01),
            new DateTime(4, 05, 06),
            new DateTime(4, 05, 24),
            new DateTime(4, 09, 06),
            new DateTime(4, 09, 22),
            new DateTime(4, 11, 01),
            new DateTime(4, 12, 24),
            new DateTime(4, 12, 25),
            new DateTime(4, 12, 26)
            };

            
            int workingDaysCount = 0;

            for (var date = firstDate; date <= lastDate; date=date.AddDays(1))
            {
                //I make a comparison date. 
                DateTime compareDate=new DateTime(4,date.Month,date.Day);

                
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday && !holydays.Contains(compareDate))
                {
                    
                    workingDaysCount++;
                }
            }

            Console.WriteLine(workingDaysCount);
        }
    }
}
