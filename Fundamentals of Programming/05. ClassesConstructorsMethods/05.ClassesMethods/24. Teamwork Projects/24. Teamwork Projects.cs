using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Team
{
    public List<string> TeamMembersList { get; set; }
    public string TeamName { get; set; }
    public string TeamLeader { get; set; }
}



class TeamworkProjects
{
    static void Main()
    {
        List<Team> teams = new List<Team>();

        int teamsToBeRegistered = int.Parse(Console.ReadLine());
        teams = RegisteringTeams(teams, teamsToBeRegistered);

        teams = PopulatingTeams(teams);

        teams = OrderingTeams(teams);

        PrintingTeams(teams);

    }

    private static void PrintingTeams(List<Team> teams)
    {
        foreach (var team in teams.Where(x => x.TeamMembersList.Count > 0))
        {
            Console.WriteLine(team.TeamName);
            Console.WriteLine($"- {team.TeamLeader}");
            foreach (var member in team.TeamMembersList.OrderBy(x => x))
            {
                Console.WriteLine($"-- {member}");

            }
        }

        Console.WriteLine("Teams to disband:");
        foreach (var team in teams.Where(x => x.TeamMembersList.Count == 0))
        {
            Console.WriteLine(team.TeamName);

        }
    }

    private static List<Team> OrderingTeams(List<Team> teams)
    {
        teams = teams.OrderByDescending(x => x.TeamMembersList.Count).ThenBy(x => x.TeamName).ToList();
        return teams;
    }

    private static List<Team> PopulatingTeams(List<Team> teams)
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end of assignment")
            {
                break;
            }

            string[] args = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            string user = args[0];
            string desiredTeam = args[1];

            var currentTeam = teams.FirstOrDefault(x => x.TeamName == desiredTeam);
            //bool found = false;


            if (!teams.Any(x => x.TeamName == desiredTeam))
            {
                Console.WriteLine($"Team {desiredTeam} does not exist!");
                continue;
            }


            else if (teams.Any(x => x.TeamLeader == user))
            {
                Console.WriteLine($"Member {user} cannot join team {desiredTeam}!");
                continue;
            }
            else if (teams.Any(x => x.TeamMembersList.Contains(user)))
            {
                Console.WriteLine($"Member {user} cannot join team {desiredTeam}!");
                continue;

            }
            else
            {

                currentTeam.TeamMembersList.Add(user);
                continue;
            }


        }
        return teams;
    }

    private static List<Team> RegisteringTeams(List<Team> teams, int teamsToBeRegistered)
    {
        for (int i = 0; i < teamsToBeRegistered; i++)
        {
            string[] tokents = Console.ReadLine().Split('-');
            string teamLeader = tokents[0];
            string desiredTeamName = tokents[1];


            Team newTeam = new Team();
            newTeam.TeamLeader = teamLeader;
            newTeam.TeamName = desiredTeamName;
            newTeam.TeamMembersList = new List<string>();

            if (teams.Any(x=> x.TeamName==desiredTeamName))
            {
                Console.WriteLine($"Team {newTeam.TeamName} was already created!");
            }
            else if (teams.Any(x => x.TeamLeader == teamLeader))
            {
                Console.WriteLine($"{teamLeader} cannot create another team!");
            }
            else if (!teams.Any(x => x.TeamName == desiredTeamName))
            {
                teams.Add(newTeam);
                Console.WriteLine($"Team {newTeam.TeamName} has been created by {newTeam.TeamLeader}!");
            }
            
        }
        return teams;
    }
}




