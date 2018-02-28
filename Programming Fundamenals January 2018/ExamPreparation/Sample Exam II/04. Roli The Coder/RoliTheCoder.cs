using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 80/100
/// </summary>
namespace _04._Roli_The_Coder
{
    class RoliTheCoder
    {
        static void Main()
        {
            string input = string.Empty;
            Dictionary<int, HashSet<string>> eventsParticipants = new Dictionary<int, HashSet<string>>();
            Dictionary<int, string> eventsName = new Dictionary<int, string>();

            while ((input = Console.ReadLine()) != "Time for Code")
            {
                string[] args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (args.Length < 2)
                {
                    continue;
                }

                int id = 0; //possible exeption if it's not a num!
                if (!int.TryParse(args[0], out id))
                {
                    continue;
                }
                string name = args[1];//event name
                if (!name.StartsWith("#"))
                {
                    //validate event name.
                    continue;
                }
                name=name.Trim('#');

                //validating participants.
                bool IsValid = true;


                if (args.Length > 2)
                {

                    for (int i = 2; i < args.Length; i++)
                    {
                        //validating participants
                        if (!args[i].StartsWith("@"))
                        {
                            IsValid = false;
                            break;
                        }
                    }

                    if (!IsValid)
                    {
                        continue;
                    }
                }

                if (eventsName.ContainsKey(id))
                {
                    var existName = eventsName[id];
                    if (existName == name)
                    {
                        for (int i = 2; i < args.Length; i++)
                        {
                            //if all are valid.
                            eventsParticipants[id].Add(args[i]);
                        }
                    }
                }
                else
                {
                    eventsName[id] = name.Trim('#');
                    eventsParticipants[id] = new HashSet<string>();

                    for (int i = 2; i < args.Length; i++)
                    {
                        //if all are valid.
                        eventsParticipants[id].Add(args[i]);
                    }
                }
            }

            //Possible mistake with the order....
            foreach (var ev in eventsParticipants.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{eventsName[ev.Key]} - {ev.Value.Count()}");
                foreach (var ppl in ev.Value.OrderBy(x=>x))
                {
                    Console.WriteLine(ppl);
                }
            }
        }


    }
}

