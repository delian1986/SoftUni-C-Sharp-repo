using System;
using System.IO;

/// <summary>
/// Program wich read text file and write all odd lines to new file.
/// </summary>
namespace _01._Odd_Lines
{
    class OddLines
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines(@"Input.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 == 1)
                {
                    File.AppendAllText(@"Output.txt", lines[i] + Environment.NewLine);
                    Console.WriteLine(lines[i]);
                }
            }
        }
    }
}
