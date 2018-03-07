using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetMin2
{
    class getMin
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            var min =getMinNum(a, b,c);

            Console.WriteLine(min);

        }

        static int getMinNum(int a, int b,int c)
        {

            return Math.Min(a, (Math.Min(b, c)));
            
        }
    }
}
