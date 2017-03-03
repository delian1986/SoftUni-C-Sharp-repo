using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintRecip();
        }
        static void PrintRecipHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
        static void Body()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        static void Botton()
        {
            Console.WriteLine("------------------------------\n© SoftUni");
        }
        static void PrintRecip()
        {
            PrintRecipHeader();
            Body();
            Botton();

        }




    }
}
