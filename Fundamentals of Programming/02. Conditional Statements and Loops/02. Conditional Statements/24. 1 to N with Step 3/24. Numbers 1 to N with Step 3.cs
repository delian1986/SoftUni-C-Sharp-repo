using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._1_to_N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <=num; i+=3)
            {
                
                Console.WriteLine(i);
            }
        }
    }
}
