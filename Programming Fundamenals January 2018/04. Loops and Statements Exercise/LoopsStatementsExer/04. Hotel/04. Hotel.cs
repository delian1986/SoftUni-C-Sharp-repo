using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            decimal price = 0M;
            decimal studio = 0m;
            decimal doubleRoom = 0m;
            decimal suite = 0m; ;

            if (month == "May" || month == "October")
            {
                if (nights > 7)
                {
                    studio = 50 - (50 * 0.05M);
                    doubleRoom = 65;
                    suite = 75;
                }
                else
                {
                    studio = 50;
                    doubleRoom = 65;
                    suite = 75;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    studio = 60 - (60 * 0.1m);
                    doubleRoom = 72;
                    suite = 82;
                }
                else
                {
                    studio = 60;
                    doubleRoom = 72;
                    suite = 82;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                if (nights > 14)
                {
                    suite = 89 - (89 * 0.15m);
                    studio = 68;
                    doubleRoom = 77;
                }
                else
                {
                    studio = 68;
                    doubleRoom = 77;
                    suite = 89;
                }
            }



            if (nights > 7 && (month == "September" || month == "October"))
            {
                studio = studio * (nights - 1);
                doubleRoom = doubleRoom * nights;
                suite = suite * nights;
            }
            else
            {
                studio = studio * nights;
                doubleRoom = doubleRoom * nights;
                suite = suite * nights;
            }



            Console.WriteLine($"Studio: {studio:f2} lv.");
            Console.WriteLine($"Double: {doubleRoom:f2} lv.");
            Console.WriteLine($"Suite: {suite:f2} lv.");

        }
    }
}
