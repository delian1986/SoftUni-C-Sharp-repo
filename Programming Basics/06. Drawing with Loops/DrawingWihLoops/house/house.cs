using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    class house
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = n % 2 == 0 ? 2 : 1;
            int size = (n % 2 == 0) ? n / 2: n/2+ 1;
            int dashes = (n % 2 == 0) ? n / 2 - 1 : n / 2;
            for (int i = 0; i < size; i++)
            {
                Console.Write( new string ('-',dashes));
                Console.Write(new string('*',stars));
                Console.Write(new string('-', dashes));

                Console.WriteLine();
                dashes--;
                stars+=2;

            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write('|');
                Console.Write(new string('*',n-2));
                Console.Write('|');
                Console.WriteLine();

            }

        }
    }
}
