using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = i+1; j <=end; j++)
                {
                    for (int n = j+1; n <=end; n++)
                    {
                        for (int m = n+1; m <= end; m++)
                        {
                            for (int o = m+1; o <= end; o++)
                            {
                                counter++;
                                Console.WriteLine($"{i} {j} {n} {m} {o}");
                            }
                        }
                    }
                }
            }

            if (counter==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
