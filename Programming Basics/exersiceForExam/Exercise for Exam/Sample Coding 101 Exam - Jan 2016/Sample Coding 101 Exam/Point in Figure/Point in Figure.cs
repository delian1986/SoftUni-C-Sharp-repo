using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            //up
            bool up = (x >= 4 && x <= 10 && y <= -3 && y>= -5);

            //left
            bool left = (x >= 10 && x <= 12 && y >= -3 && y <= 1);

            //bot
            bool bot = (x >= 4 && x <= 10 && y >= 1 && y <= 3);

            //right
            bool right = (x >= 2 && x <= 4 && y >= -3 && y <= 1);

            //center
            bool center = (x >= 4 && x <= 10 && y >= -3 && y <= 1);

            if (up||left||bot||right||center)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
