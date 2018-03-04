using System;
using System.Numerics;

/// <summary>
/// 100/100
/// </summary>

namespace _01
{
    class Program
    {
        static void Main()
        {
            decimal moneyWeHave=decimal.Parse(Console.ReadLine());
            long studentsCount=long.Parse(Console.ReadLine());
            decimal saberPrice=decimal.Parse(Console.ReadLine());
            decimal robePrice=decimal.Parse(Console.ReadLine());
            decimal beltPrice=decimal.Parse(Console.ReadLine());

            //10% more sabers.
            decimal studPercent=(studentsCount+Math.Ceiling(studentsCount*0.1m));
            decimal sabers=saberPrice*studPercent;

            decimal robes = studentsCount*(decimal)robePrice;

            //1 of 6 belts are free.
            decimal freeBelts=studentsCount/6;
            decimal belts= ((studentsCount-freeBelts)*beltPrice);

            decimal neededEquipment= sabers+robes+belts;

            if (moneyWeHave>=neededEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {neededEquipment:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(moneyWeHave-neededEquipment):f2}lv more.");
            }

        }
    }
}
