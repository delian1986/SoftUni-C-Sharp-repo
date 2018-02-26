using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/// <summary>
/// This program count number of letters in given text and write its
/// count in decending order.
/// </summary>

namespace _03._Count_of_Symbols
{
    class CountOfSymbols
    {
        static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");

            Dictionary<string, int> sequence = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                var line = text[i].ToCharArray();

                for (int j = 0; j < line.Length; j++)
                {
                    for (int k = j + 1; k < line.Length - 1; k++)
                    {
                        if (!sequence.ContainsKey(line[j].ToString()))
                        {
                            sequence.Add(line[j].ToString(), 1);
                        }
                        if (line[j] == line[k])
                        {
                            sequence[line[j].ToString()]++;

                        }
                    }
                }
            }

            foreach (var item in sequence.OrderByDescending(x=>x.Value))
            {
                StringBuilder result=new StringBuilder();
                result.Append($"{item.Key} -> {item.Value}");

                File.AppendAllText("Output.txt",result.ToString()+Environment.NewLine);
            }
        }
    }
}
