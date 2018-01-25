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

            if (month=="May"||month=="October")
            {
                if (nights>7)
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
        }
    }
}
