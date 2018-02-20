using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06IntervalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());

            int e = int.Parse(Console.ReadLine());

            int start = Math.Min(s, e);
            int end = Math.Max(s, e);
            
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
