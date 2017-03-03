using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Gravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double perc = weight * 0.17;
            Console.WriteLine("{0:F3}",perc);
        }
    }
}
