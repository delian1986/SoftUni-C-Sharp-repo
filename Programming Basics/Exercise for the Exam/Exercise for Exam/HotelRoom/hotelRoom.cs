using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class hotelRoom
    {
        static void Main(string[] args)
        {
            var mount = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());

            var nightsStudio = 0.0;
            var nightsApp = 0.0;


            if (mount == "may" || mount == "october")
            {
                var presStud = nights * 50;
                var presApp = nights * 65;
                if (nights > 0 && nights <= 7)
                {
                    nightsStudio = 50 * nights;
                    nightsApp = 65 * nights;
                }
                else if (nights > 7 && nights <= 14)
                {

                    nightsStudio = presStud - (presStud * 0.05);
                    nightsApp = nights * 65;
                    //nightsApp = appPrest - (appPrest * 0.10);

                }
                else if (nights > 14)
                {
                    nightsStudio = presStud - (presStud * 0.30);
                    nightsApp = presApp - (presApp * 0.10);
                }
            }
            if (mount == "june" || mount == "september")
            {
                var presStud = nights * 75.20;
                var presApp = nights * 68.70;
                if (nights > 0 && nights <= 7)
                {
                    nightsStudio = 75.20 * nights;
                    nightsApp = 68.70 * nights;
                }
                else if (nights > 7 && nights <= 14)
                {

                    nightsStudio = 75.20 * nights;
                    nightsApp = nights * 68.70;
                    // nightsApp = appPrest - (appPrest * 0.10);

                }
                else if (nights > 14)
                {
                    nightsStudio = presStud - (presStud * 0.20);
                    nightsApp = presApp - (presApp * 0.10);
                }
            }
            if (mount == "july" || mount == "august")
            {
                var presStud = nights * 76;
                var presApp = nights * 77;
                if (nights > 0 && nights <= 7)
                {
                    nightsStudio = 76 * nights;
                    nightsApp = 77 * nights;
                }
                else if (nights > 7 && nights <= 14)
                {

                    nightsStudio = 76 * nights;
                    nightsApp = nights * 77;
                    // nightsApp = appPrest - (appPrest * 0.10);

                }
                else if (nights > 14)
                {
                    nightsStudio = 76*nights;
                    nightsApp = presApp - (presApp * 0.10);
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", nightsApp);
            Console.WriteLine("Studio: {0:f2} lv.", nightsStudio);

        }
    }
}
