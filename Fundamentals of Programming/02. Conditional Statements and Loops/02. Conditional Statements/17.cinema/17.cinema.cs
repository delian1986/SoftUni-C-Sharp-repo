using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            var res = 0.0;

            if (film=="premiere")
            {
                res = (row * col) * 12;
            }
            else if (film=="normal")
            {

                res = (row * col) * 7.5;
            }
            else if (film == "discount")
            {

                res = (row * col) * 5;
            }

            Console.WriteLine($"{res:f2}");
        }
    }
}
