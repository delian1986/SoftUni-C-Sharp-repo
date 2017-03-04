using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGD
{
    class CGD
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            while (n2!=0)
            {
                var reminder = n1 % n2;
                n1 = n2;
                n2 = reminder;
            }
            Console.WriteLine(n1);

        }
    }
}
