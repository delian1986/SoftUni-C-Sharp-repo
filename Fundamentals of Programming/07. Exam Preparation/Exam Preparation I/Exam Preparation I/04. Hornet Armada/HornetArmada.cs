using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            var a = new int[] { 1, 2, 3, 4,56 };
            var b = new int[] { 1, 5, 56, 6,4 };

            var c = 99;

            int res = a.Intersect(b).Where(x=>x>1).Sum().CompareTo(c);

            string[] check = new string[]
            {
                "smaller than",
                "equal to",
                "bigger than"
            };

            //foreach (var item in res)
            //{
            //Console.WriteLine(item);
            //
            //}
            Console.WriteLine(check[res] + $" {c}");
        }
    }
}
