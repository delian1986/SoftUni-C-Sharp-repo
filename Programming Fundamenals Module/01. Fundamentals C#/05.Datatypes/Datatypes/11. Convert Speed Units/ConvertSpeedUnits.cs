using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            double distInMet=double.Parse(Console.ReadLine());
            double hours=double.Parse(Console.ReadLine());
            double min=double.Parse(Console.ReadLine());
            double sec=double.Parse(Console.ReadLine());

            double totSec=(hours*60*60)+(min*60)+sec;

            Console.WriteLine((float)(distInMet/ totSec));
            Console.WriteLine((float)((distInMet/1000)/(totSec/3600)));
            Console.WriteLine((float)((distInMet/1609)/(totSec/3600)));
        }
    }
}
