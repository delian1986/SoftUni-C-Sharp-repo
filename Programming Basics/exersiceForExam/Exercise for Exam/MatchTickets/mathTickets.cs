using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class mathTickets
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            string categor = Console.ReadLine().ToLower();
            var numPpl = int.Parse(Console.ReadLine());

            decimal vip = 499.99M;
            decimal normal = 249.99M;
            decimal trans = 0.0M;





            if (numPpl >= 1 && numPpl <= 4)
            {
                trans = budget * 0.75M;
            }
            else if (numPpl >= 5 && numPpl < 10)
            {
                trans = budget * 0.60M;
            }
            else if (numPpl >= 10 && numPpl < 25)
            {
                trans = budget * 0.50M;
            }
            else if (numPpl >= 25 && numPpl < 50)
            {
                trans = budget * 0.40M;
            }
            else if (numPpl >= 50)
            {
                trans = budget * 0.25M;
            }
            decimal ticketNorm = numPpl * normal;
            var ticketVip = numPpl * vip;
            var resNorm = (budget - trans - ticketNorm);
            var resVip = budget - trans - ticketVip;
            
            if (categor == "normal")
            
            {
                if (resNorm <0)
                {


                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(resNorm));

                }
                else
                {
                    var mon = trans - resNorm;
                    Console.WriteLine("Yes! You have {0:f2} leva left.", resNorm);
                }
            }
            if (categor == "vip")
            {
                if (resVip <0)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(resVip));

                }
                else
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", resVip);

                }
            }
        }


    }
}
