using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b =10;
            int temp;

            temp=b;
            b=a;
            a=temp;

            Console.WriteLine("Before:\na = 5\nb = 10\nAfter:\na = 10\nb = 5");
        }
    }
}
