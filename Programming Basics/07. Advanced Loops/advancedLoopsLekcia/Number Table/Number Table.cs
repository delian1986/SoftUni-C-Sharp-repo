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
            // var sec 
            var row = 0;
            var col = 0;

            for (row = 0; row < n; row++)
            {

                for (col = 0; col < n; col++)
                {
                    var num = row + col + 1;

                    Console.Write(num + " ");
                    // if ()
                    // {
                    //     num = 2 * n - num;
                    //     Console.Write(num + " ");
                    // }
                }
                Console.WriteLine();
            }

        }
    }
}
