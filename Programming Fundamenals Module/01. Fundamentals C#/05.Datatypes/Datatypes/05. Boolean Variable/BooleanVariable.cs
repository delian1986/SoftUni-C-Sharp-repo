using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();

            bool isItTrue=Convert.ToBoolean(text);
            string result;
            if (isItTrue)
            {
                result="Yes";
            }
            else
            {
                result="No";
            }

            Console.WriteLine(result);
        }
    }
}
