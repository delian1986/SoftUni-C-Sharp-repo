using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double wid = double.Parse(Console.ReadLine());
            double len = double.Parse(Console.ReadLine());
            double trianWid = double.Parse(Console.ReadLine());
            double trianHeigh = double.Parse(Console.ReadLine());
            double sumPlate = double.Parse(Console.ReadLine());
            double sumCraft = double.Parse(Console.ReadLine());

            double floor = wid * len;
            double plate = trianHeigh * trianWid / 2;
            double plateNeed = Math.Ceiling(floor / plate + 5);
            double sumAll = plateNeed * sumPlate + sumCraft;

            var res = (Math.Abs(money-sumAll));
            if (money>=sumAll)
            {
                
                Console.WriteLine("{0:f2} lv left.",res);
            }
            else if (sumAll>money)
            {
                Console.WriteLine("You'll need {0:f2} lv more.",res);
            }

        }
    }
}
