using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int max = Int32.MinValue;
            

            for (int i = 0; i < num; i++)
            {
                int nextNum = int.Parse(Console.ReadLine());

                
                    if (nextNum>max)
                {
                    max = nextNum;
                }
            }
            Console.WriteLine(max);
        }
    }
}
