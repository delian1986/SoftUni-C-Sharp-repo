using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainers
{
    class trainSal
    {
        static void Main(string[] args)
        {
            int lecture = int.Parse(Console.ReadLine());
            var budget = decimal.Parse(Console.ReadLine());

            var jelev = 0;
            var royal = 0;
            var roli = 0;
            var trifon = 0;
            var sino = 0;
            var others = 0;

            for (int i = 0; i < lecture; i++)
            {
                var name = Console.ReadLine().ToLower();

                if (name =="jelev")
                {
                    jelev++;
                }
                else if (name=="royal")
                {
                    royal++;
                }
                else if (name=="roli")
                {
                    roli++;
                }
                else if (name=="trofon")
                {
                    trifon++;
                }
                else if (name=="sino")
                {
                    sino++;
                }
                else 
                {
                    others++;
                }
            }
            var money = budget / lecture;
            var jelevSal = money* jelev;
            var royalSal = money* royal;
            var roliSal = money* roli;
            var trifonSal = money* trifon;
            var sinoSal = money* sino;
            var otherSal = budget - (jelevSal + royalSal + roliSal + trifonSal + sinoSal);

            Console.WriteLine($"Jelev salary: {jelevSal:f2} lv");
            Console.WriteLine($"RoYaL salary: {royalSal:f2} lv");
            Console.WriteLine($"Roli salary: {roliSal:f2} lv");
            Console.WriteLine($"Trofon salary: {trifonSal:f2} lv");
            Console.WriteLine($"Sino salary: {sinoSal:f2} lv");
            Console.WriteLine($"Others salary: {otherSal:f2} lv");

        }


    }
}
