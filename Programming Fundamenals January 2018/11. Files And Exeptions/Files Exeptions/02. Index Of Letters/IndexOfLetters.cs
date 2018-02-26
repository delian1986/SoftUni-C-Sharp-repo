using System;
using System.IO;
using System.Text;
/// <summary>
/// This program read sequence of letters and write their possition in
/// new file.
/// </summary>

namespace _02._Index_Of_Letters
{
    class IndexOfLetters
    {
        static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");

            foreach (string line in text)
            {

                foreach (char letter in line)
                {
                    StringBuilder result= new StringBuilder();
                    result.Append($"{letter} -> {letter-97}");

                    File.AppendAllText("Output.txt",result.ToString()+Environment.NewLine);
                }
            }
        }
    }
}
