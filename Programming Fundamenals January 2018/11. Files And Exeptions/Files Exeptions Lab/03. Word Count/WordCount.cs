using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// This program read key words, count key words in text and write new file
/// with occurencises ordered by desending.
/// </summary>

namespace _03._Word_Count
{
    class WordCount
    {
        static void Main()
        {
            string words = File.ReadAllText(@"words.txt").ToLower();
            string text = File.ReadAllText(@"text.txt").ToLower();

            string[]keyWords=words.Split();

            Dictionary<string, int> occurencies = new Dictionary<string, int>();

            for (int i = 0; i < keyWords.Length; i++)
            {
                string pattern = $@"\b{keyWords[i]}\b";

                foreach (Match word in Regex.Matches(text,pattern))
                {
                    string w=word.ToString();
                    if (!occurencies.ContainsKey(w))
                    {
                        occurencies.Add(w,0);
                    }
                    occurencies[w]++;
                }
            }

            var ordered=occurencies.OrderByDescending(x=>x.Value);

            foreach (var line in ordered)
            {
                File.AppendAllText(@"Output.txt",line.Key+" "+"-"+" "+line.Value+Environment.NewLine);
            }
        }
    }
}
