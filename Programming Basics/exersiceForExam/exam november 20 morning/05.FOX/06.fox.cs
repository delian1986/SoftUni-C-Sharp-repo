using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FOX
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var col = 2 * n + 3;
            var mid = (2 * n + 3) - 4;
            //upper
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', i + 1));
                Console.Write('\\');
                Console.Write(new string('-', mid));
                Console.Write('/');
                Console.WriteLine(new string('*', i + 1));
                mid -= 2;
            }

            //mid
            var midLeftRightStar = n / 2;
            var midStar = n;
            for (int i = 0; i < n / 3; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', midLeftRightStar));
                Console.Write('\\');
                Console.Write(new string('*', midStar));
                Console.Write('/');
                Console.Write(new string('*', midLeftRightStar));
                Console.WriteLine('|');
                midLeftRightStar++;
                midStar -= 2;
            }

            //bott
            var bmid = (2 * n + 3) - 4;


            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', i + 1));
                Console.Write('\\');
                Console.Write(new string('*', bmid));
                Console.Write('/');
                Console.WriteLine(new string('-', i + 1));
                bmid -= 2;
            }


        }
    }
}
