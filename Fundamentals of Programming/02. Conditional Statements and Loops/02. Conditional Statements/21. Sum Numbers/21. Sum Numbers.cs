using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 0; i < num; i++)
            {
                int nextNum = int.Parse(Console.ReadLine());
                sum += nextNum;
            }

            Console.WriteLine(sum);
        }
    }
}
