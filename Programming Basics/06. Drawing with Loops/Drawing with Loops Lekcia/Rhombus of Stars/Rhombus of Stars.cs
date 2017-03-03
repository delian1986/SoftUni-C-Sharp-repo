using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
          //  var space = n - 1;
            //var star = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(' ');

                }
                Console.Write('*');

                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
            for (int i =n; i >= 1; i--)
            {
                for (int j =n-i; j >= 1; j--)
                {
                    Console.Write(' ');

                }
               // Console.Write('*');

                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();

            }
        }
    }
}
