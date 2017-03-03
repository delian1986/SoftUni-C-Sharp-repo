using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asci_table
{
    class asciTable
    {
        static void Main(string[] args)
        {
            char symb;
            for (symb = (char)33; symb <= 126; symb++)
            {
                Console.Write(symb);
            }
        }
    }
}
