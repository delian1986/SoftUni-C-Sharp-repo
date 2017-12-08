using System;

namespace _04.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            var stud = int.Parse(Console.ReadLine());

            var poor = 0.0;
            var satis = 0.0;
            var good = 0.0;
            var vryGood = 0.0;
            var exel = 0.0;

            for (int i = 0; i < stud; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade<22.5)
                {
                    poor++;
                }
                else if (grade>22.5 && grade<40.5)
                {
                    satis++;
                }
                else if (grade>40.5 && grade<58.5)
                {
                    good++;
                }
                else if (grade > 58.5 && grade < 76.5)
                {
                    vryGood++;
                }
                else
                {
                    exel++;
                }
            }

            double poorMarks = poor *100 / stud;
            double satisMarks = satis *100/ stud;
            var goodMarks = good *100/ stud;
            var vryGoodMarks = vryGood *100/ stud;
            var exelMarks = exel *100/ stud;

            Console.WriteLine($"{poorMarks:f2}% poor marks");
            Console.WriteLine($"{satisMarks:f2}% satisfactory marks");
            Console.WriteLine($"{goodMarks:f2}% good marks");
            Console.WriteLine($"{vryGoodMarks:f2}% very good marks");
            Console.WriteLine($"{exelMarks:f2}% excellent marks");


        }
    }
}
