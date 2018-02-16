using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

/// <summary>
/// This program collect information about students. Their names, attend dates and comments. 
/// It keeps them in list of class Students. At the end the program prints report in console. 
/// https://judge.softuni.bg/Contests/Compete/Index/210#7
/// 90/100 so far....
/// </summary>

namespace _08._Mentor_Group
{
    class Program
    {
        static void Main()
        {
            //This is the main list where the program store the Students info.
            List<Student> classRoom = new List<Student>();
            string studentActivities = string.Empty;

            //Attend dates section.
            while ((studentActivities = Console.ReadLine()) != "end of dates")
            {
                string[] tokents = studentActivities.Split(new char[] { ' ', ',' });

               
                string studentName = tokents[0];
                List<DateTime> datesAtended = new List<DateTime>();

                for (int i = 1; i < tokents.Length; i++)
                {
                    datesAtended.Add(DateTime.ParseExact(tokents[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                if (classRoom.Any(x => x.Name == studentName))
                {
                    var currStud = classRoom.First(x => x.Name == studentName);
                    currStud.Dates.AddRange(datesAtended);
                }
                else
                {

                    Student newStudent = new Student
                    {
                        Name = studentName,
                        Dates = datesAtended,
                        Comments = new List<string>()
                    };
                    classRoom.Add(newStudent);
                }
            }

            //Comments section.
            while ((studentActivities = Console.ReadLine()) != "end of comments")
            {
                string[] tokents = studentActivities.Split(new char[] { '-' });
                string studentName = tokents[0];
                List<string> comments = new List<string>();
                comments = tokents.Skip(1).ToList();

                //If the student has no attend dates.
                if (!classRoom.Any(x => x.Name == studentName))
                {
                    continue;
                }
                else
                {
                    var currStud = classRoom.First(x => x.Name == studentName);
                    currStud.Comments.AddRange(comments);
                }
            }

            //Here the program print the result.
            foreach (var student in classRoom.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{student.Name}");
                Console.WriteLine($"Comments:");
                foreach (var comment in student.Comments)
                {

                    Console.WriteLine($"- {string.Join("", comment)}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}
