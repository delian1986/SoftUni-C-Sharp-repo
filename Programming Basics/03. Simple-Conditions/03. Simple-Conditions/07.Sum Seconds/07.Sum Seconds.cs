using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());
            var totalMin = 0.00;
            var totalSec = firstTime + secondTime+ thirdTime;
            if (totalSec <60)
            {
                
            }
            else if (totalSec<120)
            {
                totalMin =+ 1;
                totalSec = totalSec-60;
            }
            else if (totalSec<180)
            {
                totalMin = 2;
                totalSec =totalSec-120;
            }
            if (totalSec<10)
            {
                Console.WriteLine("{0}:0{1}",totalMin,totalSec);
            }
            else
            {
                Console.WriteLine("{0}:{1}", totalMin, totalSec);
            }
        }
    }
}
