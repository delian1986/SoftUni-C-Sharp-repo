using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var fromMetric = Console.ReadLine();
            var toMetric = Console.ReadLine();
            double baseMetric = value;
            if (fromMetric == "m")
            {
                baseMetric= baseMetric*1 ;
            }
            else if (fromMetric =="mm")
            {
                value = value * 1000;
            }
            else if (fromMetric == "cm")
            {
                value = value * 1000;
            }
            else if (fromMetric == "mi")
            {
                value = value * 1000;
            }
            else if (fromMetric == "in")
            {
                value = value * 1000;
            }
            else if (fromMetric == "km")
            {
                value = value * 1000;
            }
            else if (fromMetric == "ft")
            {
                value = value * 1000;
            }
            else if (fromMetric == "yd")
            {
                value = value * 1000;
            }
        }
    }
}
