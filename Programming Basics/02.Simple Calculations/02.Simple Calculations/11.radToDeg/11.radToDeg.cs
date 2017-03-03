using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.radToDeg
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double res = (int)(rad * (180 / Math.PI));
            Console.WriteLine("Degrees = {0}",res);
        }
    }
}
