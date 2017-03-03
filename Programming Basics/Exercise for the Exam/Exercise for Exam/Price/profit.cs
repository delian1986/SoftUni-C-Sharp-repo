using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price
{
    class profit
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            decimal proftPerDay = decimal.Parse(Console.ReadLine());
            decimal usdToLev = decimal.Parse(Console.ReadLine());

            var mounts = proftPerDay * workDays;
            var year = (mounts * 12) + (mounts * 2.5M);
            var fee = year * 0.25M;
            var resultUsd = year - fee;
            var convertToLev = resultUsd * usdToLev;
            var levPerDay = convertToLev / 365;
            Console.WriteLine("{0:f2}", levPerDay);

        }
    }
}
