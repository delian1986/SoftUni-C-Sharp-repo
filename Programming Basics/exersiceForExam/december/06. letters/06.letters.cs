using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());
            double count = 0;
            for (char i = a; i <= b; i++)
            {
                for (char j = a; j <= b; j++)
                {
                    for (char k = a; k <= b; k++)
                    {
                        if (i != skip && j != skip && k != skip)
                        {
                            count++;

                            Console.Write("{0}{1}{2} ", i, j, k);
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}