using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int jun = int.Parse(Console.ReadLine());
            int sen = int.Parse(Console.ReadLine());
            decimal track = Console.ReadLine();
            decimal cost = 0.00m;
            decimal tax = 0.00m;
            decimal res = 0.00m;
            if (track == "trail")
            {
                decimal junCost = 5.5m;
                decimal senCost = 7.00m;
                cost = jun * junCost + sen * senCost;
                tax = cost * 0.05m;
                res = cost - tax;
            }
            else if (track == "cross-country")
            {
                decimal junCost = 8m;
                decimal senCost = 9.50m;
                cost = jun * junCost + sen * senCost;
                tax = cost * 0.05m;
                res = cost - tax;
                if (jun + sen >= 50)
                {
                    res = res - (res * 0.25m);
                }
            }
            else if (track == "downhill")
            {
                decimal junCost = 12.25m;
                decimal senCost = 13.75m;
                cost = jun * junCost + sen * senCost;
                tax = cost * 0.05m;
                res = cost - tax;
            }
            else
            {
                decimal junCost = 20m;
                decimal senCost = 21.50m;
                cost = jun * junCost + sen * senCost;
                tax = cost * 0.05m;
                res = cost - tax;
            }
            Console.WriteLine("{0:f2}",res);
        }
    }
}
