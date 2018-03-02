using System;
using System.Text.RegularExpressions;

/// <summary>
/// 90/100
/// </summary>

namespace _03._Snowflake
{
    class Snowflake
    {
        static void Main()
        {
            bool validSurface = false;
            bool validMante = false;
            bool validCore = false;
            string core = string.Empty;

            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    string surface = Console.ReadLine();
                    string patternForSurface = @"[^A-Za-z0-9]+";

                    if (Regex.IsMatch(surface, patternForSurface))
                    {
                        validSurface = true;
                    }
                }
                else if (i == 1)
                {
                    string mante = Console.ReadLine();
                    string patternForMante = @"[0-9_]+\b";

                    if (Regex.IsMatch(mante, patternForMante))
                    {
                        validMante = true;
                    }
                }
                else if (i == 2)
                {
                    string coreInput = Console.ReadLine();
                    string patternForCore = @"^([^A-Za-z0-9]+)([0-9_]+)(?<core>[A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)$";

                    if (Regex.IsMatch(coreInput, patternForCore))
                    {
                        validCore = true;

                        foreach (Match item in Regex.Matches(coreInput, patternForCore))
                        {
                            core = item.Groups["core"].Value;
                        }
                    }
                }
                else if (i==3)
                {
                     string mante = Console.ReadLine();
                    string patternForMante = @"[0-9_]+";

                    if (Regex.IsMatch(mante, patternForMante))
                    {
                        validMante = true;
                    }
                    else
                    {
                        validMante=false;
                    }
                }
                else if (i == 4)
                {
                    string surface = Console.ReadLine();
                    string patternForSurface = @"[^A-Za-z0-9]+";

                    if (Regex.IsMatch(surface, patternForSurface))
                    {
                        validSurface = true;
                    }
                    else
                    {
                        validSurface=false;
                    }
                }
            }

            if (validSurface&&validMante&&validCore)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(core.Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
