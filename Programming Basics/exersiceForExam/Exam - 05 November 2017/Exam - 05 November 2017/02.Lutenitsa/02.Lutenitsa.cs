using System;

namespace _02.Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var tomat = double.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            double kilo =  (tomat / 5d);
            var bank = kilo / 0.535 ;
            var cases = bank / y;

            Console.WriteLine($"Total lutenica: {kilo:f0} kilograms.");
            if (cases>x)
            {
                var res = Math.Floor(cases - x);
                var res1 = Math.Floor(bank - (x * y));
                Console.WriteLine($"{res} boxes left.");
                Console.WriteLine($"{res1} jars left.");
            }
            else
            {
                var res = Math.Floor(x - cases);
                var res1 = Math.Floor((x * y) - bank);
                Console.WriteLine($"{res} more boxes needed.");
                Console.WriteLine($"{res1} more jars needed.");
            }
        }
    }
}
