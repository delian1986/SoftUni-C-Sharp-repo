using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]daysOfTheWeek=new string[]
            {
                "monday",
                "tuesday",
                "wednesday",
                "thursday",
                "friday",
                "saturday",
                "sunday"

            };

            int day=int.Parse(Console.ReadLine());

            if (day<1||day>7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysOfTheWeek[day-1]);
            }

        }
    }
}
