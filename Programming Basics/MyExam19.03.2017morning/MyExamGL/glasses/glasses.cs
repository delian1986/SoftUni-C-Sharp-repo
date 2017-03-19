using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glasses
{
    class glasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var outside = 1;
            var size = 2 * n + 1;
            var inside = size - 6;

            //top
            Console.WriteLine(new string('*',size));
            Console.Write(new string('.', outside));
            Console.Write('*');
            Console.Write(new string(' ',size-4));
            Console.Write('*');
            Console.WriteLine(new string('.', outside));


            //upperbody
            for (int i = 1; i <=size/2-2; i++)
            {
                outside++;
                Console.Write(new string('.', outside));
                Console.Write('*');
                Console.Write(new string('@',inside));
                Console.Write('*');
                Console.WriteLine(new string('.', outside));
                inside -= 2;
            }

            //center
            outside++;

            Console.Write(new string('.',outside));
            Console.Write('*');
            Console.WriteLine(new string('.',outside));

            //bottbody
            var insideSpace = 0;
            for (int i = 1; i <=size/2-2; i++)
            {
                outside--;
                Console.Write(new string('.',outside));
                Console.Write('*');
                Console.Write(new string(' ',insideSpace));
                Console.Write('@');
                Console.Write(new string(' ', insideSpace));
                Console.Write('*');
                Console.WriteLine(new string('.', outside));
                insideSpace++;
            }
            Console.Write('.');
            Console.Write('*');
            Console.Write(new string('@',size-4));
            Console.Write('*');
            Console.WriteLine('.');

            Console.WriteLine(new string('*', size));


        }
    }
}
