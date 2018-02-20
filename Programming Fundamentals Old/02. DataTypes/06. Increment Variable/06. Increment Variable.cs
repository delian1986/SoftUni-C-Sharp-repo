using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                int n = int.Parse(Console.ReadLine());
                int count = 0;
                byte bit = 0;
                for (int i = 0; i < n; i++)
                {
                    bit++;
                    if (bit==0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{bit}");
                if (count>0)
                {
                    Console.WriteLine($"Overflowed {count} times");
                }
            }

        }
    }
}
