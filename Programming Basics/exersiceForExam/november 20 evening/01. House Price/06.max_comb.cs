using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal start = int.Parse(Console.ReadLine());
            decimal end = int.Parse(Console.ReadLine());
            decimal stop = int.Parse(Console.ReadLine());

            decimal comb = 1;

            for (int i = start; i <=end; i++)
            {
                for (int j = start; j <=end; j++)
                {
                    Console.Write("<{0}-{1}>",i,j);
                    comb++;
                    if (comb>stop)
                    {
                        return;
                    }
                }
            }
        }
    }
}
