using System;

namespace _01._Yesterday
{
    class Program
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);
            DateTime dayBefore = date.AddDays(-1);
            string oneDayBack = dayBefore.ToString("dd-MMM-yyyy");
            Console.WriteLine(oneDayBack);
        }
    }
}
