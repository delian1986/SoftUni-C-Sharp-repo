using System;
using System.Collections.Generic;
using System.Linq;


namespace _04._Fix_Emails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> emailBook= new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name=="stop")
                {
                    break;
                }
                string email = Console.ReadLine();

                if (!email.Contains(".us")||email.Contains(".uk"))
                {
                    if (!emailBook.ContainsKey(name))
                    {
                        emailBook.Add(name,string.Empty);
                    }
                    emailBook[name]=email;
                }

            }

            foreach (var address in emailBook)
            {
                Console.WriteLine($"{address.Key} -> {address.Value}");
            }
        }
    }
}
