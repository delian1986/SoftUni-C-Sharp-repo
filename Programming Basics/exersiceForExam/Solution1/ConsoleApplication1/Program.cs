using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secTime = int.Parse(Console.ReadLine());
            int trdTime = int.Parse(Console.ReadLine());

            decimal firstHour = firstTime / 60m;
            decimal secHour = secTime / 60m;
            decimal trdHour = trdTime / 60m;

            var firstSpeed = speed;
            var secSpeed = firstSpeed + (firstSpeed * 0.10m);
            var trdSpeed = secSpeed - (secSpeed * 0.05m);

            var firstDist = speed * firstHour;
            var secDist = secSpeed * secHour;
            var trdDist = trdHour * trdSpeed;
            var res = firstDist + secDist + trdDist;
            Console.WriteLine("{0:f2}", res);
        }
    }
}
