using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Three_Brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

            }
            string fix = "-";
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(String.Concat(Enumerable.Repeat(fix, i+1)));
                Console.WriteLine(num[i]);
                
            }

        }
    }
}
