using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

/// <summary>
/// 87/100
/// https://judge.softuni.bg/Contests/Compete/Index/210#8
/// </summary>

public class MentorGroup
{
    public static void Main()
    {
        List<Team> teams = new List<Team>();

        int linesOfAsigment = int.Parse(Console.ReadLine());

        for (int i = 0; i < linesOfAsigment; i++)
        {
            string[] teamRegister = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string teamLeader = teamRegister[0];
            string desiredName = teamRegister[1];

            if (teams.Any(x => x.TeamName == desiredName))
            {
                Console.WriteLine($"Team {desiredName} was already created!");
            }
            else if (teams.Any(x => x.Creator == teamLeader))
            {
                Console.WriteLine($"{teamLeader} cannot create another team");
            }
            else
            {
                Team newTeam = new Team
                {
                    TeamName = desiredName,
                    Creator = teamLeader,
                    TeamMembers = new List<string>()
                };
                teams.Add(newTeam);
                Console.WriteLine($"Team {desiredName} has been created by {teamLeader}!");
            }
        }//End of team creation.

        //Populating teams.
        string assigment = string.Empty;
        while ((assigment = Console.ReadLine()) != "end of assignment")
        {
            string[] teamPopulate = assigment.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string member = teamPopulate[0];
            string desiredTeam = teamPopulate[1];

            if (!teams.Any(x => x.TeamName == desiredTeam))
            {
                Console.WriteLine($"Team {desiredTeam} does not exist!");
            }
            else if (teams.Any(x => x.Creator == member)||teams.Any(x=>x.TeamMembers.Contains(member)))
            {
                Console.WriteLine($"Member {member} cannot join team {desiredTeam}!");
            }
            else if (teams.Any(x => x.TeamName == desiredTeam))
            {
                var currTeam = teams.First(x => x.TeamName == desiredTeam);
                currTeam.TeamMembers.Add(member);
            }
        }//End of team populating

        foreach (var team in teams.Where(x => x.TeamMembers.Count > 0)
            .OrderByDescending(x => x.TeamMembers.Count).ThenBy(x=>x.TeamName))
        {
            Console.WriteLine($"{team.TeamName}");
            Console.WriteLine($"- {team.Creator}");
            foreach (var members in team.TeamMembers.OrderBy(x => x))
            {
                Console.WriteLine($"-- {members}");
            }
        }

        Console.WriteLine($"Teams to disband:");
        foreach (var teamToDisband in teams.Where(x => x.TeamMembers.Count == 0).OrderBy(x=>x.TeamName))
        {
            Console.WriteLine($"{teamToDisband.TeamName}");
        }

    }
}

class Team
{
    public string Creator { get; set; }
    public string TeamName { get; set; }
    public List<string> TeamMembers { get; set; }
}