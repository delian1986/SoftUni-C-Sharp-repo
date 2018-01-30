using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int decNum=int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("{0:x}",decNum).ToUpper());
            Console.WriteLine(Convert.ToString(decNum,2));
        }
    }
}
