using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Team
{
    public List<string> TeamMembers { get; set; }
    public string TeamName { get; set; }
    public string TeamLeader { get; set; }
}



class TeamworkProjects
{
    static void Main(string[] args)
    {
        List<Team> teams = new List<Team>();
        TeamCreation(teams);

        string members = Console.ReadLine();
        while (members != "end of assignment")
        {
            string[] assigment = members.Split('-', '>').ToArray();
            string user = assigment[0];
            string desiredTeam = assigment[1];
            List<string> memberList = new List<string>();

            if (teams.Any(name => name.TeamName == desiredTeam))
            {
                memberList.Add(user);
                Team member = new Team
                {
                    TeamMembers = memberList
                };
                
            }

        }

        members = Console.ReadLine();
    }

    private static void TeamCreation(List<Team> teams)
    {
        int input = int.Parse(Console.ReadLine());
        for (int i = 0; i < input; i++)
        {
            string[] teamsToBeCreated = Console.ReadLine().Split('-');
            string userName = teamsToBeCreated[0];
            string desiredName = teamsToBeCreated[1];

            if (!teams.Any(name => name.TeamName == desiredName))
            {
                Team newTeam = new Team
                {
                    TeamName = desiredName,
                    TeamLeader = userName,
                };

                teams.Add(newTeam);
                Console.WriteLine($"Team {newTeam.TeamName} has been created by {newTeam.TeamLeader}!");
            }
            else
            {
                Console.WriteLine($"Team {desiredName} was already created!");
            }

        }
    }
}



