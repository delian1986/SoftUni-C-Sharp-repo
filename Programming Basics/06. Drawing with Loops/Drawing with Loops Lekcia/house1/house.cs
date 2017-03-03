using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house1
{
    class house
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int roof = 0;
            var stars = 1;

            if (n % 2 == 0)
            {
                stars++;
            }

            //roof body
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                var dash = (n - stars) / 2;
                Console.Write(new string('-', dash));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', dash));
                stars += 2;
            }
            //bottom
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');

            }
        }
    }
}
