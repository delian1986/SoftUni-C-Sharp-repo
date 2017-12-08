using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int dayOfTheWeek = int.Parse(Console.ReadLine());
            if (dayOfTheWeek<=0||dayOfTheWeek >7)
            {
                Console.WriteLine("Invalid Day!");
                return;
            }
            dayOfTheWeek--;
            for (int i = 0; i <= day.Length-1; i++)
            {
                if (i==dayOfTheWeek)
                {
                    Console.WriteLine(day[i]);
                }
            }
        }
    }
}
