using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        string[] input = Console.ReadLine().Split(',', ' ');
        List<Students> stud = new List<Students>();
        while (input[0] != "end" && input[1] != "of")
        {
            List<string> dates = AddingTokensToList(input);
            List<DateTime> date = dates.Select(x => DateTime.Parse(x)).ToList();

            Students s = new Students
            {

                Name = input[0],
                Dates = date,
                Comments = new List<string>()
            };
            stud.Add(s);

            input = Console.ReadLine().Split();
        }

        input = Console.ReadLine().Split('-');
        while (input[0] != "end of comments")
        {
            string name = input[0];
            string comments = input[1];
            foreach (var item in stud.Where(x=>x.Name.Equals(name)))
            {
                item.Comments.Add(comments);
            }
            input = Console.ReadLine().Split('-');
        }

        foreach (var name in stud.OrderBy(x=>x.Name))
        {
            Console.WriteLine(name.Name);
            Console.WriteLine("Comments:");
            foreach (var comment in name.Comments)
            {
                Console.WriteLine($"- {comment}");
            }

            Console.WriteLine("Dates attended:");
            foreach (var date in name.Dates.OrderBy(x =>x.Date))
            {
                string dates = date.ToString("dd/MM/yyyy");
                Console.WriteLine($"-- {dates}");
            }
          
        }
    }


    private static List<string> AddingTokensToList(string[] input)
    {
        var tokents = new List<string>();
        for (int i = 1; i < input.Length; i++)
        {
            tokents.Add(input[i]);
        }

        return tokents;
    }
}
