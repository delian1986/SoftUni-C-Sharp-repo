using System;
using System.IO;

/// <summary>
/// This program read text file and write the lines with their numbers.
/// </summary>

namespace _02._Line_Numbers
{
    class LineNumbers
    {
        static void Main()
        {
            string[]text=File.ReadAllLines(@"Input.txt");

            int lineCount=0;

            for (int i = 0; i < text.Length; i++)
            {
                lineCount++;
                File.AppendAllText(@"Output.txt",lineCount+"."+" "+text[i]+Environment.NewLine);
            }
        }
    }
}
