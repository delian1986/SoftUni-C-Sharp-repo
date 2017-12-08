using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 1; i <=n; i++)
            {
                for (int j = 0; j <i; j++)
                {
                Console.Write($"{count} ");
                    count++;
                    if (count > n)
                    {
                        Console.WriteLine();
                        return;
                    }

                }
                Console.WriteLine();
               
            }
        }
    }
}
