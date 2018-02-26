using System;
using System.Linq;
using System.Numerics;

/// <summary>
/// This program convert number in decimal to N numeric system.
/// https://judge.softuni.bg/Contests/Practice/Index/321#0
/// </summary>

namespace ConvertFromBase10toN
{
    class ConvertFromBase10ToBaseN
    {
        static void Main()
        {
            BigInteger[]numbers=Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            //N system.
            BigInteger numericSystem=numbers[0];
            //Number in decimal.
            BigInteger numInDecimal=numbers[1];
            BigInteger reminder=0;
            string result=string.Empty;

            while (numInDecimal>0)
            {
                reminder=numInDecimal%numericSystem;
                numInDecimal/=numericSystem;
                result=reminder.ToString()+result;
            }

            Console.WriteLine(result);
        }
    }
}
