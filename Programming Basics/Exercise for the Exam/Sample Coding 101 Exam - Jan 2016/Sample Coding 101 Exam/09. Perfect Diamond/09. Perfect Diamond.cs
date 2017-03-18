using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dashStar = 0;
            var space = n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ',space));
                Console.Write('*');
                Console.WriteLine(string.Concat(Enumerable.Repeat("-*", dashStar)));
                dashStar++;
                space--;
            }
            space = 0;
            dashStar --;
            for (int i = n-1; i>0 ; i--)
            {
                dashStar--;
                space++;
                Console.Write(new string(' ', space));
                Console.Write('*');
                Console.WriteLine(string.Concat(Enumerable.Repeat("-*", dashStar)));
                

            }
        }
    }
}
