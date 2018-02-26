using System;

/// <summary>
/// This program compares two strings before and after '@'.
/// Print a message after on result.
/// https://judge.softuni.bg/Contests/Practice/Index/585#1
/// </summary>

namespace _02._Email_me
{
    class EmailMe
    {
        static void Main()
        {
            string mail = Console.ReadLine();
            int kliomba = mail.IndexOf('@');
            var name = mail.Substring(0, kliomba).ToCharArray();
            var host = mail.Substring(kliomba+1, (mail.Length - 1) - kliomba).ToCharArray();


            int nameSum = SumOfChars(name);
            int hostSum = SumOfChars(host);


            if (nameSum - hostSum >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }

        private static int SumOfChars(char[] name)
        {
            int sum = 0;
            foreach (var character in name)
            {
                sum += character;
            }
            return sum;
        }
    }
}
