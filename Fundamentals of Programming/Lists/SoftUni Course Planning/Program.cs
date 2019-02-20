using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main()
        {
            List<string> plan = Console.ReadLine().Split(", ").ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commands = input.Split(":");
                string action = commands[0];
                string course = commands[1];

                switch (action)
                {
                    case "Add":
                        if (!plan.Contains(course))
                        {
                            plan.Add(course);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(commands[2]);

                        

                        if (index >=0 || index <plan.Count())
                        {
                            if (!plan.Contains(course))
                            {
                                plan.Insert(index,course);
                            }
                        }
                            
                        break;

                    case "Remove":
                        if (plan.Contains(course))
                        {
                            plan.Remove(course);
                        }
                        break;
                    case "Swap":
                        string lessonTitle1 = commands[1];
                        string lessonTitle2 = commands[2];

                        if (plan.Contains(lessonTitle1) && plan.Contains(lessonTitle2))
                        {

                        }
                        break;
                }
            }

            for (int i = 0; i < plan.Count(); i++)
            {
                Console.WriteLine($"{i+1}.{plan[i]}");
            }
        }
    }
}
