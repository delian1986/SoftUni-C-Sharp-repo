using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fort
{
    class fort
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());         //

            var fort = n / 2;                             // s premenlivata "fort" oboznachavam vytreshnata shirina na kulite (bliznaci:P)


            var wall = ((2 * n) - (2 * (n / 2))) - 4;     //s promenlivata "wall" oboznachavam razstoqnieto menjdu kulite. Do formulata se stiga sas slednata logika-> 2*n                                                  (cqlata shirna na fort) - n/2 (vaytreshnata shirina na kulite)-4 (zaduljitelnite nakloneni cherti ot                                                           vynshnite steni na kulite)


            if (wall < 0)                                 // garantiram si 4e pri otricatelen resultat na formulata za "wall" nqma da mi dade error.
            {
                wall = 0;
            }

            //top                                           printiram nai - gorniqt red
            Console.Write("/");
            Console.Write(new string('^', fort));
            Console.Write(@"\");
            Console.Write(new string('_', wall));
            Console.Write("/");
            Console.Write(new string('^', fort));
            Console.WriteLine(@"\");


            //body                                          for cikal ot 2-riqt red do predposleniqt red ot tqloto (2red do n-2 red, tqh priniram otdelno)
            for (int j = 0; j < n - 3; j++)
            {
                Console.Write('|');
                Console.Write(new string(' ', fort));
                Console.Write(new string(' ', wall));
                Console.Write(new string(' ', fort + 2));


                Console.Write('|');

                Console.WriteLine();

            }


            //bodyLastLine                                          nalaga se da izpriniram posleniqt red ot tqloto otdelno zaradi dolnata 4erta s                                                                                s razstoqnie =wall
            Console.Write('|');
            Console.Write(new string(' ', fort + 1));
            Console.Write(new string('_', wall));
            Console.Write(new string(' ', fort + 1));
            Console.WriteLine('|');



            //bottom                                                posleden red
            Console.Write(@"\");
            Console.Write(new string('_', fort));
            Console.Write("/");
            Console.Write(new string(' ', wall));
            Console.Write(@"\");
            Console.Write(new string('_', fort));
            Console.WriteLine("/");

        }
    }
}
