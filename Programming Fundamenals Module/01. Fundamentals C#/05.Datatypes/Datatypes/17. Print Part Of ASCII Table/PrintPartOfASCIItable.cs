using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class PrintPartOfASCIItable
    {
        static void Main(string[] args)
        {
            int symb1=int.Parse(Console.ReadLine());
            int symb2=int.Parse(Console.ReadLine());


            for (int i = symb1; i <= symb2; i++)
            {
                char symb=(char) i;

                Console.Write(symb+" ");
            }
            Console.WriteLine();
        }
    }
}
