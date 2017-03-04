using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            double slab = 0;
            double sreden = 0;
            double dobar = 0;
            double mnDobar = 0;
            double otlicen = 0;
            double uspeh = 0;
            for (int i = 0; i < n; i++)
            {
                double rate = double.Parse(Console.ReadLine());
                if (rate >= 2.00 && rate <= 2.99)
                {
                    slab++;
                    uspeh += rate;
                }
                else if (rate >= 3.00 && rate <= 3.99)
                {
                    sreden++;
                    uspeh += rate;

                }
                else if (rate >= 4.00 && rate <= 4.99)
                {
                    dobar++;
                    uspeh += rate;

                }
                else if (rate >= 5.00 && rate <= 6.99)
                {
                    mnDobar++;
                    uspeh += rate;

                }
            }
            double top = mnDobar / n * 100;
            double pet = dobar / n * 100;
            double chet = sreden / n * 100;
            double dve = slab / n * 100;
            double aver = uspeh / n;

            Console.WriteLine("Top students: {0:f2}%",top);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", pet);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%",chet );
            Console.WriteLine("Fail: {0:f2}%", dve);
            Console.WriteLine("Average: {0:f2}", aver);

        }
    }
}
