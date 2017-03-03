using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    class hospital
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            var doc = 7;
            var treat = 0;
            var untreat = 0;

            for (int i = 1; i <= days; i++)
            {
                int pac = int.Parse(Console.ReadLine());

                if (i%3==0&&untreat>treat)
                {
                    doc++;
                    if (pac<=doc)
                    {
                        treat += pac;
                    }
                    else
                    {
                        treat += doc;
                    }
                    
                    if (pac>doc)
                    {
                        untreat += Math.Abs(pac - doc);
                    }
                    

                }
                else if (pac<=doc)
                {
                    treat += pac; 
                }
                else if (pac>doc)
                {
                    treat += doc;
                    untreat += pac - doc;
                }
            }
            Console.WriteLine("Treated patients: {0}.",treat);
            Console.WriteLine("Untreated patients: {0}.",untreat);
        }
    }
}
