using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class incElem
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int incElem = 0;
            int prev = 0;
            int secInc = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());


                if (prev < num)
                {
                    incElem++;
                }
                
                else if (prev>=num)
                {
                    
                    incElem = 1;
                }
                if (incElem > secInc)
                {
                    secInc = incElem;

                }


                prev = num;

            }
           
            Console.WriteLine(Math.Max(incElem, secInc));
        }
    }
}
