using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            bool found = false;

            for (int i = -n; i <= 0; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int k = -n; k <= 0; k++)
                    {
                        for (int l = 0; l <= n; l++)
                        {
                            if (-n <= i && i < j && j <= n && -n <= k && k < l && l <= n)
                            {
                                var sideA = Math.Abs(i)+Math.Abs(j);
                                var sideB = Math.Abs(k) +Math.Abs(l);
                                if (sideA * sideB >= m)
                                {
                                    var res = sideA * sideB;
                                    Console.WriteLine($"({i}, {k}) ({j}, {l}) -> {res}");
                                    found = true;
                                }
                                
                            }
                        }
                    }
                }
            }
            if (found==false)
            {
                Console.WriteLine("No");
            }
        }
    }
}