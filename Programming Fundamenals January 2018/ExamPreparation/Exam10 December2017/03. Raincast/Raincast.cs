using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/881#0
/// </summary>

namespace _03._Raincast
{
    class Program
    {
        static void Main()
        {
            List<List<string>> forecast = new List<List<string>>();

            string input = string.Empty;
            List<string> current = new List<string>();

            while ((input = Console.ReadLine()) != "Davai Emo")
            {
                if (current.Count == 0)
                {
                    if (input == "Type: Normal" || input == "Type: Warning" || input == "Type: Danger")
                    {
                        var type=input.Split();
                        current.Add(type[1].Trim());
                    }

                }
                else if (current.Count == 1)
                {
                    Regex reg = new Regex(@"^Source:\ ([a-zA-Z0-9]+)$");
                    if (reg.IsMatch(input))
                    {
                        var type=input.Split(':');
                        current.Add(type[1].Trim());
                    }
                }
                else if (current.Count == 2)
                {
                    var fore = input.Split();
                    if (fore[0] == "Forecast:")
                    {
                        var check = input.ToCharArray();
                        if (!check.Any(x => x == '!' || x == '.' || x == ',' || x == '?'))
                        {
                        var type=input.Split(':');
                            current.Add(type[1].Trim());
                        }
                    }
                }
                if (current.Count == 3)
                {
                    forecast.Add(current.ToList());
                    current.Clear();
                }
            }

            foreach (var list in forecast)
            {
                Console.WriteLine($"({list[0]}) {list[2]} ~ {list[1]}");
            }
        }
    }
}
