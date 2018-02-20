using System;
using System.Collections.Generic;
using System.Numerics;
class DifferentIntegersSize
{
    static void Main()
    {
        BigInteger num = BigInteger.Parse(Console.ReadLine());
        List<string> fitsIn = new List<string>();

        if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
        {
            fitsIn.Add("sbyte");
        }
        if (num >= byte.MinValue && num <= byte.MaxValue)
        {
            fitsIn.Add("byte");
        }
        if (num >= short.MinValue && num <= short.MaxValue)
        {
            fitsIn.Add("short");
        }
        if (num >= ushort.MinValue && num <= ushort.MaxValue)
        {
            fitsIn.Add("ushort");
        }
        if (num >= int.MinValue && num <= int.MaxValue)
        {
            fitsIn.Add("int");
        }
        if (num >= uint.MinValue && num <= uint.MaxValue)
        {
            fitsIn.Add("uint");
        }
        if (num >= long.MinValue && num <= long.MaxValue)
        {
            fitsIn.Add("long");
        }
        

        if (fitsIn.Count==0)
        {
            Console.WriteLine($"{num} can't fit in any type");
        }
        else
        {
            Console.WriteLine($"{num} can fit in:");
            foreach (string dataType in fitsIn)
            {
                Console.WriteLine("* "+ dataType);
            }
        }
    }
}
