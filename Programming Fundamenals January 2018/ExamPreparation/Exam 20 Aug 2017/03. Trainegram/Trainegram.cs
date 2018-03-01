using System;
using System.Text.RegularExpressions;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/742#0
/// </summary>

namespace _03._Trainegram
{
    class Trainegram
    {
        static void Main()
        {
            string text=string.Empty;
            string pattern=@"^(<\[[^A-Za-z0-9]*\].){1}(.\[([A-Za-z0-9])*\].)*$";

            Regex reg= new Regex(pattern);

            while ((text=Console.ReadLine())!="Traincode!")
            {
                if (reg.IsMatch(text))
                {
                    Console.WriteLine(text);
                }
            }

        }
    }
}
