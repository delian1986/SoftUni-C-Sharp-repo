using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stop
{
    class stop
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dot = (n + 1);
            var line = (n *2)+1;
            var inner = (n * 2) - 1;

            //top
            Console.Write(new string ('.',dot));
            Console.Write(new string ('_',line));
            Console.WriteLine(new string('.', dot));

            //upbody
            for (int row = 1; row <=n; row++)
            {
                Console.Write(new string('.',dot-1));
                Console.Write(new string('/',2));
                Console.Write(new string('_',inner));
                Console.Write(new string('\\', 2));
                Console.WriteLine(new string('.',dot-1));
                dot--;
                inner+=2;
            }

            //center
            Console.Write(new string('/',2));
            Console.Write(new string('_',(n*2)-3));
            Console.Write("STOP!");
            Console.Write(new string('_', (n*2)-3));
            Console.WriteLine(new string('\\', 2));

            //botBody
            dot = 0;
            for (int row = 1; row <=n; row++)
            {
                Console.Write(new string('.',dot));
                Console.Write(new string('\\',2));
                Console.Write(new string('_',inner));
                Console.Write(new string('/', 2));
                Console.WriteLine(new string('.', dot));
                dot ++;
                inner-=2;

            }

        }
    }
}
