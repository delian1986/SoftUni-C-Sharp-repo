using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var count = 1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    var num = row + col + 1;

                    if (row+col<n )
                    {
                        Console.Write("{0} ", num);
                    }
                    else
                    {
                        Console.Write("{0} ",2*n-num);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
