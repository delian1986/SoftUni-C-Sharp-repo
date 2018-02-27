using System;
using System.Text.RegularExpressions;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/692#0
/// 100/100
/// </summary>

namespace _03._Regexmon
{
    class Regexmon
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string didiPattern = @"[^A-Za-z-]+";
            string bojoPattern = @"[A-Za-z]+-[A-Za-z]+";

            int count = 1;
            int didiPos = 0;
            int bojoPos = 0;

            //Loop while there is no match.
            while (true)
            {
                //Didi start fist on odd index.
                if (count % 2 == 1)
                {
                    Match didi = Regex.Match(text, didiPattern);
                    if (!Regex.IsMatch(text, didiPattern))
                    {
                        break;
                    }
                    //Trim text to the position of last index.
                    text = text.Substring(text.IndexOf(didi.Value) + didi.Value.Length);
                    Console.WriteLine(didi.Value);
                    count++;
                }
                else
                {
                    Match bojo = Regex.Match(text, bojoPattern);
                    if (!Regex.IsMatch(text, bojoPattern))
                    {
                        break;
                    }
                    //Trim text to the position of last index.
                    text = text.Substring(text.IndexOf(bojo.Value) + bojo.Value.Length);
                    Console.WriteLine(bojo.Value);
                    count++;
                }


            }

        }
    }
}
