using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Time__15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute += 15;

            var result = String.Empty;

            if (minute >59)
            {
                minute -= 60;
                hour++;
            }
            if (hour>23)
            {
                hour -= 24;
            }
            if (minute<10)
            {
                Console.WriteLine($"{hour}:0{minute}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minute}");

            }


        }
    }
}
