using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

/// <summary>
/// https://judge.softuni.bg/Contests/Compete/Index/430#5
/// </summary>

namespace _06._Valid_Usernames
{
    class ValidUsernames
    {
        static void Main()
        {

            string text=Console.ReadLine();
            //Pattern for valid user names.
            string pattent = @"\b[A-Za-z][\w]{2,25}\b";

            //We store valids here.
            List<string>validNames= new List<string>();
            foreach (Match m in Regex.Matches(text,pattent))
            {
                validNames.Add(m.Value);
            }

            int sum=0;
            int longest=0; 
            string[]longestNames=new string[2];

            //We check for the longest pair.
            for (int i = 0; i < validNames.Count-1; i++)
            {
                sum=validNames[i].Length+validNames[i+1].Length;

                if (sum>longest)
                {
                    longest=sum;
                    longestNames[0]=validNames[i];
                    longestNames[1]=validNames[i+1];
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,longestNames));
        }
    }
}
