using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        //SortedDictionary<string,double> exellentStud= new SortedDictionary<string, double>();
            Student[] student = new Student[n];

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var grades = new List<double>();
            foreach (var item in input.Skip(1))
            {
                grades.Add(double.Parse(item));
            }

            var stud = new Student
            {
                Name = input[0],
                Grades=grades
            };
            student[i] = stud;
            
        }

        foreach (var item in student.Where(x=> x.AverangeGrade>=5).OrderBy(x=>x.Name).ThenByDescending(x =>x.AverangeGrade))
        {
            Console.WriteLine($"{item.Name} -> {item.AverangeGrade:f2}");
        }
       
    }

    
}
class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AverangeGrade => Grades.Average();
}
