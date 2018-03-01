using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Trainegram
{
    class Program
    {
        static void Main()
        {
            string input=string.Empty;
            List<string>trains=new List<string>();

            while ((input=Console.ReadLine())!="Traincode!")
            {
                Regex train= new Regex(@"^(\<\[[^a-zA-Z0-9]+\]\.)(.\[[A-Za-z0-9]+\].)*$");

                if (train.IsMatch(input))
                {
                    trains.Add(train.ToString());
                } 
            }

            Console.WriteLine(string.Join(Environment.NewLine,trains));
        }
    }
}
