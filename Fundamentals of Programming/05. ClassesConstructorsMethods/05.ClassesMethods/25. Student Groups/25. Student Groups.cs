using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Student_Groups
{
    class Student
    {
        public string StudentName { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }

    }

    class Town
    {
        public string TownName { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Town> towns = ReadInput();
            List<Group> groups = DistributeStudentsIntoGroups(towns);

            PrintResult(groups);

        }

        private static void PrintResult(List<Group> groups)
        {
            var groupCount = groups.Count();
            var townCount = groups.Select(x => x.Town.TownName).Distinct().Count();
            Console.WriteLine($"Created {groupCount} groups in {townCount} towns:");
            foreach (var group in groups.OrderBy(x=>x.Town.TownName))
            {
                Console.WriteLine($"{group.Town.TownName}=> {string.Join(", ",group.Students.Select(x=>x.Email))}");
            }
        }

        private static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();
            foreach (var town in towns.OrderBy(x => x.TownName))
            {
                IEnumerable<Student> students = town.Students.OrderBy(x => x.RegisterDate).ThenBy(x => x.StudentName).ThenBy(x => x.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }


            return groups;
        }

        static List<Town> ReadInput()
        {
            var towns = new List<Town>();
            string currentTown = String.Empty;

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                string[] tokens = inputLine.Split(new string[] { "=>", "|", "seats" }, StringSplitOptions.RemoveEmptyEntries);

                if (inputLine.Contains("=>"))
                {
                    Town newTown = new Town
                    {
                        TownName = tokens[0],
                        SeatsCount = int.Parse(tokens[1]),
                        Students = new List<Student>()
                    };
                    currentTown = newTown.TownName;
                    towns.Add(newTown);
                }
                else
                {
                    string student = tokens[0].Trim();
                    string mail = tokens[1].Trim();
                    string date = tokens[2].Trim();
                    Student newStudent = new Student
                    {
                        StudentName = student,
                        Email = mail,
                        RegisterDate = DateTime.ParseExact(date, "d-MMM-yyyy", CultureInfo.InvariantCulture)
                    };
                    var studentsToAdd = towns.Find(x => x.TownName == currentTown);
                    studentsToAdd.Students.Add(newStudent);
                }

            }

            return towns;
        }
    }
}
