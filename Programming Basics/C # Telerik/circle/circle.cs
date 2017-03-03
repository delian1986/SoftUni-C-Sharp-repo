using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class circle
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            var per = 2 * Math.PI * rad;
            var area = Math.PI * rad*rad;

            Console.WriteLine("{0:f2} {1:f2}",per,area);
        }
    }
}
