using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class money
    {
        static void Main(string[] args)
        {
            var bit = double.Parse(Console.ReadLine());
            var ch = double.Parse(Console.ReadLine());
            var comm = double.Parse(Console.ReadLine());
            var commRes = comm/100; 

            var bitLev = 1168 * bit;
            var chToUsd = ch * 0.15;
            var usdToLev = chToUsd * 1.76;
            var leva = (bitLev + usdToLev) / 1.95;
            var takenComm = (leva * commRes);
            Console.WriteLine(leva-takenComm); 
        }
    }
}
