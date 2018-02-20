using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Average_Grades
{
    /// <summary>
    /// Program witch calculate averange grade for a student.
    /// https://judge.softuni.bg/Contests/Compete/Index/210#3
    /// </summary>
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
    }
    class AverageGrades
    {
        static void Main()
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            List<Student>studentList= new List<Student>();

            for (int i = 0; i < numOfStudents; i++)
            {
                List<double> grades = new List<double>();
                string[] line = Console.ReadLine().Split();
                string studentName=line[0];

                grades = PopulatingListOfGrades(grades,line);

                Student currStudent=new Student
                {
                    Name=studentName,
                    Grades=grades
                };
                studentList.Add(currStudent);
            }

            foreach (var student in studentList.Where(x=>x.Grades.Average()>=5.00).OrderBy(x=>x.Name).ThenByDescending(x=>x.Grades.Average()))
            {
                Console.WriteLine($"{student.Name} -> {student.Grades.Average():f2}");
            }
        }

        private static List<double> PopulatingListOfGrades(List<double> grades,string[]line)
        {
            for (int i = 1; i < line.Length; i++)
            {
                grades.Add(double.Parse(line[i]));
            }
               return grades;
        }
    }
}
