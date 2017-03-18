using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harves
{
    class harvest
    {
        static void Main(string[] args)
        {
            var fieldSqMet = double.Parse(Console.ReadLine());
            var grapePerSqMet = double.Parse(Console.ReadLine());
            var litersNeeded = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());

            var totalGrape = fieldSqMet * grapePerSqMet;
            var vine = (totalGrape * 0.40) / 2.5;

            if (vine >= litersNeeded)
            {
                var res = (vine - litersNeeded);
                var bonus = (res / workers);
                
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Ceiling(res),Math.Ceiling(bonus));
            }
            else
            {
                var res = litersNeeded - vine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(res)); 
                
            }

        }
    }
}
