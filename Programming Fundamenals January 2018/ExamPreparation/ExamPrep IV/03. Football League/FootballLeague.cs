using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/456#2
/// </summary>

namespace _03._Football_League
{
    class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public long Goals { get; set; }
    }
    class FootballLeague
    {
        static void Main()
        {
            List<Team> standing = new List<Team>();
            string pattern=Regex.Escape(Console.ReadLine());

            string patternTeams = $@"({pattern})(.*?)(\1)";
            string scorePattern = @"(\d+):(\d+)";

            Regex reg = new Regex(patternTeams);
            string text = string.Empty;

            while ((text = Console.ReadLine()) != "final")
            {
                var teamMatches = Regex.Matches(text, patternTeams);
                int teamCounter = 1;
                Team curr1 = new Team();
                Team curr2 = new Team();


                foreach (Match item in teamMatches)
                {
                    string team = item.Groups[2].Value.ToUpper();
                    team = NameReverse(team);
                    if (teamCounter == 1)
                    {
                        curr1.Name = team;

                        var exist = standing.FirstOrDefault(x => x.Name == team);
                        if (exist == null)
                        {
                            standing.Add(curr1);
                        }
                        else
                        {
                            curr1 = exist;
                        }
                    }
                    else
                    {
                        curr2.Name = team;
                        var exist = standing.FirstOrDefault(x => x.Name == team);
                        if (exist == null)
                        {
                            standing.Add(curr2);
                        }
                        else
                        {
                            curr2 = exist;
                        }
                    }
                    teamCounter++;
                }

                var resultMatches = Regex.Matches(text, scorePattern);

                foreach (Match score in resultMatches)
                {
                    long goals1 = long.Parse(score.Groups[1].Value);
                    long goals2 = long.Parse(score.Groups[2].Value);

                    curr1.Goals += goals1;
                    curr2.Goals += goals2;

                    if (goals1 == goals2)
                    {
                        curr1.Points += 1;
                        curr2.Points += 1;
                    }
                    else if (goals1 > goals2)
                    {
                        curr1.Points += 3;
                    }
                    else if (goals1 < goals2)
                    {
                        curr2.Points += 3;
                    }
                }
            }
            var orderByPoints = standing
                .OrderByDescending(x => x.Points)
                .ThenBy(x=>x.Name);

            int count = 1;
            Console.WriteLine("League standings:");
            foreach (var team in orderByPoints)
            {
                Console.WriteLine($"{count}. {team.Name} {team.Points}");
                count++;
            }

            var orderByGoals=standing
                .OrderByDescending(x=>x.Goals)
                .ThenBy(x=>x.Name);
            count=1;

            Console.WriteLine($"Top 3 scored goals:");
            foreach (var topScore in orderByGoals)
            {
                Console.WriteLine($"- {topScore.Name} -> {topScore.Goals}");
                count++;
                if (count>3)
                {
                    break;
                }
            }
        }

        private static string NameReverse(string team)
        {
            char[] revesing = team.ToCharArray();
            Array.Reverse(revesing);
            return new string(revesing);
        }
    }
}
