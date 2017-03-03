using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace axe
{
    class axe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var upRows = n - 1;
            var col = 5 * n;
            var leftDash = 3 * n;
            var rightDash = col-leftDash - 2;
            var innerDash = 1;
            var edgeInner = n - 1;
            var edgeRight = n - 1;


            //top
            Console.Write(new string('-',leftDash));
            Console.Write(new string('*',2));
            Console.WriteLine(new string('-',rightDash));

            //body
            for (int row = 1; row <=upRows; row++)
            {
                Console.Write(new string('-',leftDash));
                Console.Write('*');
                Console.Write(new string('-',innerDash));
                Console.Write('*');
                Console.WriteLine(new string('-',rightDash-1));
                innerDash++;
                rightDash--;
            }

            //handle
            for (int i = 1; i <=n/2; i++)
            {
                Console.Write(new string('*',leftDash+1));
                Console.Write(new string('-',n-1));
                Console.Write('*');
                Console.WriteLine(new string('-',n-1));
            }

            //edge
            for (int cow = 1; cow <= (n - 2) / 2; cow++)
            {
                Console.Write(new string('-',leftDash));
                Console.Write('*');
                Console.Write(new string('-', edgeInner));
                Console.Write('*');
                Console.WriteLine(new string('-', edgeRight));
                edgeInner=edgeInner+2;
                leftDash--;
                edgeRight --;
            }

            //bott
            Console.Write(new string('-', leftDash));
            Console.Write(new string('*', edgeInner+2));
            Console.WriteLine(new string('-', edgeRight));


        }
    }
}
