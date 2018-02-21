using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main()
        {
            string text=Console.ReadLine();
            string pattern= @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var regex=Regex.Matches(text,pattern);

            foreach (Match name in regex)
            {
                Console.Write(name+" ");
            }
            Console.WriteLine();
        }
    }
}
