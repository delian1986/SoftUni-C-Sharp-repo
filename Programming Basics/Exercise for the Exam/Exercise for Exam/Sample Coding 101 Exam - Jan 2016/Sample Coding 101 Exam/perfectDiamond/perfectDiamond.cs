using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectDiamond
{
    class perfectDiamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var left = n - 1;
            var inner = 1;

            //top
            Console.Write(new string(' ',left));
            Console.WriteLine('*');
            if (n<2)
            {
                return;
            }

            //upBody
            for (int i = 1; i < n; i++)
            {
                left--;
                Console.Write(new string(' ',left));
                Console.Write('*');
                Console.WriteLine(String.Concat(Enumerable.Repeat("-*", inner)));
                inner++;
            }
            //botBody
            inner--;
            for (int i = 1; i <n-1; i++)
            {

                left++;
                inner--;

                Console.Write(new string(' ', left));
                Console.Write('*');
                Console.WriteLine(String.Concat(Enumerable.Repeat("-*", inner)));
            }

            //bottom
            left++;
            Console.Write(new string(' ', left));
            Console.WriteLine('*');
        }
    }
}
