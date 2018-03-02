using System;
using System.Collections.Generic;
using System.Numerics;

/// <summary>
/// 100/100
/// </summary>

namespace _01._Anonymous_Downsite
{
    class Program
    {
        static void Main()
        {
            int sitesDown = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            List<string> sites = new List<string>();
            decimal totalLoss= 0M;

            for (int i = 0; i < sitesDown; i++)
            {
                string[] damage = Console.ReadLine().Split();
                sites.Add(damage[0]);

                long siteVisits = long.Parse(damage[1]);
                decimal siteCommercialPrice = decimal.Parse(damage[2]);
                decimal siteLoss=siteVisits*siteCommercialPrice;
                totalLoss+=siteLoss;
            }

            Console.WriteLine(string.Join(Environment.NewLine,sites));
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey),sitesDown)}");
        }
    }
}
