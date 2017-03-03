using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal earthToStar = 4.22m * 9450000000000;
            Console.WriteLine(earthToStar.ToString("e2"));

            decimal centerOfGalaxy = 26000m * 9450000000000;
            Console.WriteLine(centerOfGalaxy.ToString("e2"));

            decimal millkyWay = 100000m * 9450000000000;
            Console.WriteLine(millkyWay.ToString("e2"));

            decimal earthToTheEdge = 46500000000m * 9450000000000;
            Console.WriteLine(earthToTheEdge.ToString("e2"));


        }
    }
}
