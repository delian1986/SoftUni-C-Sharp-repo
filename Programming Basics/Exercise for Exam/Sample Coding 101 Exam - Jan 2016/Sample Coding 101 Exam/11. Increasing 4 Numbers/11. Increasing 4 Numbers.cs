using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (b-a<=2)
            {
                Console.WriteLine("no");
            }

            for (int i = a; i <=b-3 ; i++)
            {
                for (int j = a+1; j <=b-2; j++)
                {
                    for (int k = a+2; k <=b-1; k++)
                    {
                        for (int l = a+3; l <= b; l++)
                        {
                            if (i==j||j==k||l==k||i==k||i==l||j==k||j==l)
                            {
                                continue;
                            }
                            if (i<j&&j<k&&k<l)
                            {
                                Console.WriteLine($"{i} {j} {k} {l}");

                            }
                        }
                    }
                    
                }
            }
        }
    }
}
