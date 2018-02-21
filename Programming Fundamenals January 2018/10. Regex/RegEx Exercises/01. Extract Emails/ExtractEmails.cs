using System;
using System.Text.RegularExpressions;

/// <summary>
/// This pattern extract e-mails by given restrictions.
/// https://judge.softuni.bg/Contests/Practice/Index/430#0
/// </summary>

namespace _01._Extract_Emails
{
    class ExtractEmails
    {
        static void Main()
        {
            string text=Console.ReadLine();
            string pattern=@"(?<=\s)([a-z]+|[\d]+)(\.|\-)?\w+@([a-z]+|[\d]+)(\.|\-)?(\.+)?([a-z]+)(\.+)?([a-z]+)\.([a-z]+)";

            foreach (Match mail in Regex.Matches(text,pattern))
            {
                Console.WriteLine(mail);
            }
        }
    }
}
