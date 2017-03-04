using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secTime = int.Parse(Console.ReadLine());
            int trdTime = int.Parse(Console.ReadLine());

            var timeHour = firstTime / 60;
            var secHour = secTime / 60;
            var trdHour = trdTime / 60;
            var secSpeed = (speed + (speed * 0.10);
            var firstDist = speed * timeHour;
            var secDist = secSpeed * secHour;
            var trdDist = speed - (secSpeed * 0.05) * trdHour;
            var res = firstDist + secDist + trdDist;
            Console.WriteLine("{0:f2}", res);
        }
    }
}
