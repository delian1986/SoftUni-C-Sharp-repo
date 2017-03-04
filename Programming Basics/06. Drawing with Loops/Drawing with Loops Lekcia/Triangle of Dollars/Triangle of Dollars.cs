using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int currentRow = 1; currentRow <= n; currentRow++)
            {
                Console.WriteLine('$');
                for (int currentCol  = 1; currentCol  < currentRow; currentCol ++)
                {
                    Console.Write('$');
                    
                }
                Console.WriteLine();
            }
        }
    }
}
