using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondExam
{
    class DiamondExam
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var outSideDots = n;
            var topStars = 3 * n;
            var insideDots = 3 * n;

            //top
            Console.Write(new string('.', outSideDots));
            Console.Write(new string('*', topStars));
            Console.WriteLine(new string('.', outSideDots));

            //upperBody
            for (int row = 1; row <= n-1; row++)
            {
                outSideDots--;
                Console.Write(new string('.', outSideDots));
                Console.Write('*');
                Console.Write(new string('.', insideDots));
                Console.Write('*');
                Console.WriteLine(new string('.', outSideDots));
                insideDots += 2;
            }

            //mid
            Console.WriteLine(new string('*', 5 * n));

            //bottBody
            for (int row = 1; row <= (2 * n); row++)
            {
                insideDots-=2;

                Console.Write(new string('.',outSideDots));
                Console.Write('*');
                Console.Write(new string('.', insideDots));
                Console.Write('*');
                Console.WriteLine(new string('.', outSideDots));
                outSideDots++;
            }

            //bottom
            Console.Write(new string('.', outSideDots));
            //Console.Write('*');
            Console.Write(new string('*', n-2));
            //Console.Write('*');
            Console.WriteLine(new string('.', outSideDots));



        }
    }
}
