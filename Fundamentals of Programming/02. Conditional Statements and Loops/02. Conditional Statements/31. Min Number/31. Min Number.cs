using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int min = Int32.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                if (newNum<min)
                {
                    min = newNum;
                }
                
            }
            Console.WriteLine(min);
        }
    }
}
