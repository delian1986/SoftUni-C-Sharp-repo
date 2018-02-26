using System;
using System.IO;
using System.Text;

/// <summary>
/// This program check for valid email and write them to a file.
/// </summary>

namespace _05._Fix_Emails
{
    class FixEmails
    {
        static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");

            for (int i = 1; i < input.Length; i+=2)
            {
                if (input[i]=="stop")
                {
                    break;
                }

                if (!(input[i].EndsWith(".us")||input[i].EndsWith(".uk")))
                {
                    StringBuilder validMail=new StringBuilder();
                    validMail.Append($"{input[i-1]} -> {input[i]}");
                    File.AppendAllText("Output.txt",validMail.ToString()+Environment.NewLine);
                }
            }
            
        }
    }
}
