using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string hexNum=Console.ReadLine();

            int decNum=Convert.ToInt32(hexNum,16);

            Console.WriteLine(decNum);
        }
    }
}
