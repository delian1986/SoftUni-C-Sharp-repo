using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_sec_sam
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            var totalSec = first + second + third;
            var min = 0;
            if (totalSec <60)
            {

            }
            else if (totalSec<120)
            {
                totalSec -= 60;
                min += 1;
            }
            else if (totalSec<180)
            {
                totalSec -= 120;
                min += 2;
            }
            if (totalSec<10)
            {
                Console.WriteLine("{0}:0{1}", min,totalSec);
            }
            else
            {
                Console.WriteLine("{0}:{1}", min,totalSec);
                
            }
        }
    }
}
