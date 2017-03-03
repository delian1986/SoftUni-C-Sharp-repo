using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhombOfStars
{
    class rhombOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var row = 1; row <= n; row++)
            {
                for (var spaceCol = 1; spaceCol <= n - row; spaceCol++)
                {
                    Console.Write(" ");
                }
                for (var col = 1; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }

            for (var row = n - 1; row >= 1; row--)
            {
                for (var spaceCol = 1; spaceCol <= n - row; spaceCol++)
                {
                    Console.Write(" ");
                }
                for (var col = 1; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");


            }
        }
    }
}
