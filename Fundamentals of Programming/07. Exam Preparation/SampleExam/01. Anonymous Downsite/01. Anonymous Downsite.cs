using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class AnonymousDownsite
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int secKey = int.Parse(Console.ReadLine());
        List<string> affSites = new List<string>();
        decimal totalLoss = 0m;
        BigInteger secToken = BigInteger.Pow(secKey, n);

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            string siteName = input[0];
            decimal siteVisits = decimal.Parse(input[1]);
            decimal siteCommercialPricePerVisits = decimal.Parse(input[2]);

            decimal loss = siteVisits * siteCommercialPricePerVisits;
            totalLoss += loss;

            affSites.Add(siteName);
        }

        foreach (var site in affSites)
        {
            Console.WriteLine(site);
        }
        Console.WriteLine($"Total Loss: {totalLoss:f20}");
        Console.WriteLine($"Security Token: {secToken:f0}");
    }
}
