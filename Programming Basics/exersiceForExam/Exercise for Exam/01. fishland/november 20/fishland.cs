using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_20
{
    class fishland
    {
        static void Main(string[] args)
        {
            double skum = double.Parse(Console.ReadLine());
            double caca = double.Parse(Console.ReadLine());
            double pala = double.Parse(Console.ReadLine());
            double saf = double.Parse(Console.ReadLine());
            double midi = double.Parse(Console.ReadLine());

            var palaPrice = skum+ (skum * 0.60);
            var palaSum = pala * palaPrice;
            var safPrice = caca + (caca * 0.80);
            var safSum = saf * safPrice;
            var midiSum = midi * 7.50;
            var allSum = palaSum + safSum + midiSum;

            Console.WriteLine("{0:f2}", allSum);
        }
    }
}
