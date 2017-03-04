using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());

            var medics = 7;
            var exam = 0;
            var unexam = 0;


            for (int i = 1; i <= days; i++)
            {
                var patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && unexam > exam)
                {
                    medics += 1;

                }
                if (patients > medics)
                {
                    unexam += patients - medics;
                    exam += medics;
                }
                else if (medics >= patients)
                {
                    exam += patients;
                }
                
            }
            Console.WriteLine("Treated patients: {0}.",exam);
            Console.WriteLine("Untreated patients: {0}." ,unexam);
        }
    }
}
