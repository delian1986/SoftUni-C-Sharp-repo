using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Sequence_2k___1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;

            for (int i = 0; i <n; i++)
            {
               if (num>n)
               {
                   return;
               }
                Console.WriteLine(num);
                num *= 2;
                    num+= 1;
            }
        }
    }
}
