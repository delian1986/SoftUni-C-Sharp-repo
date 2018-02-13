using System;
using System.Linq;

namespace _06._Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            double[] capacity=Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] usagePerHour=Console.ReadLine().Split().Select(double.Parse).ToArray();
            int hours=int.Parse(Console.ReadLine());

            for (int i = 0; i < capacity.Length; i++)
            {
                var time=usagePerHour[i]*hours;
                if (time<=capacity[i])
                {
                    var energy=capacity[i]-time;
                    Console.WriteLine($"Battery {i+1}: {(energy):f2} mAh ({(energy/capacity[i]*100):f2})%");
                }
                else
                {
                    var res= Math.Ceiling(capacity[i]/usagePerHour[i]);
                    Console.WriteLine($"Battery {i+1}: dead (lasted {res:f0} hours)");
                }
            }

        }
    }
}
