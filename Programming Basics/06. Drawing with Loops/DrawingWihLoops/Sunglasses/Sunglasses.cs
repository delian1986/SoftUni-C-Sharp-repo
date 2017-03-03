using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var frame = new string('*', 2 * n);
            var space = new string(' ', n);
            var glass = new string('/', (2 * n) - 2);
            var midFrame = new string('|', n);

            Console.WriteLine("{0}{1}{0}",frame,space);
            for (var row= 1;row<=n-2; row++)
            {
                Console.Write("{0}{1}{0}","*",glass);
                if (row==(n-1)/2)
                {
                    Console.Write(midFrame);
                }
                else
                {
                    Console.Write(space);
                }

                Console.WriteLine("{0}{1}{0}","*",glass);

            }
            Console.WriteLine("{0}{1}{0}", frame, space);



        }
    }
}
