using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Students
{
    public List<DateTime> Dates { get; set; }
    public List<string> Comments { get; set; }
    public string Name { get; set; }
}


class MentorGroup
{
    static void Main(string[] args)
    {
        List<Students> listOfStudents = new List<Students>();
        listOfStudents = PopulatingDatesInList(listOfStudents);
        listOfStudents = PopulatingCommentsInList(listOfStudents);

        ResultPrinter(listOfStudents);
    }

    private static void ResultPrinter(List<Students> listOfStudents)
    {
        foreach (var name in listOfStudents.OrderBy(x => x.Name).ThenBy(x => x.Dates))
        {
            string joinDates = string.Join("", name.Dates);
            string format = "dd/MM/yyyy";
            Console.WriteLine(name.Name);
            Console.WriteLine("Comments:");
            if (name.Comments.Count > 0)
            {
                foreach (var item in name.Comments)
                {
                    Console.WriteLine("- {0}", string.Join("", item));

                }

            }
            Console.WriteLine("Dates attended:");
            foreach (DateTime date in name.Dates.OrderBy(x => x.Date))
            {

                Console.WriteLine("-- {0}", date.ToString(format));
            }
        }
    }

    private static List<Students> PopulatingCommentsInList(List<Students> listOfStudents)
    {
        while (true)
        {
            string inputLine = Console.ReadLine();

            if (inputLine == "end of comments")
            {
                break;
            }

            string[] tokens = inputLine.Split('-');

            string name = tokens[0];
            string comment = tokens[1];

            if (listOfStudents.Any(x => x.Name == name))
            {
                var commentar = listOfStudents.FirstOrDefault(x => x.Name == name);
                commentar.Comments.Add(comment);
            }
        }
        return listOfStudents;
    }

    private static List<Students> PopulatingDatesInList(List<Students> listOfStudents)
    {
        while (true)
        {
            string inputLine = Console.ReadLine();

            if (inputLine == "end of dates")
            {
                break;
            }

            string[] tokens = inputLine.Split(',', ' ');

            Students newStudent = new Students
            {
                Comments = new List<string>(),
                Dates = new List<DateTime>(),
                Name = tokens[0]
            };
            for (int i = 1; i < tokens.Length; i++)
            {
                var date = DateTime.ParseExact(tokens[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                newStudent.Dates.Add(date);
            }
            listOfStudents.Add(newStudent);
        }
        return listOfStudents;
    }
}
