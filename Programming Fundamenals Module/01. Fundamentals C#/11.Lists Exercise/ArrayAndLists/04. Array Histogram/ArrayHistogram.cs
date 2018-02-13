using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Array_Histogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            List<string> seqence = Console.ReadLine().Split().ToList();
            Dictionary<string, SortedDictionary<int, double>> dict = new Dictionary<string, SortedDictionary<int, double>>();

            for (int i = 0; i < seqence.Count; i++)
            {
                int count = 1;
                string word = seqence[i];
                for (int j = i + 1; j < seqence.Count ; j++)
                {
                    if (seqence[i] == seqence[j])
                    {
                        count++;
                    }
                }
                if (!dict.ContainsKey(seqence[i]))
                {
                    double percent=((double)count / seqence.Count)*100;
                    dict.Add(word, new SortedDictionary<int, double>());
                    dict[word].Add(count,percent);
                }
            }

            foreach (var word in dict.OrderByDescending(x=>x.Value.Keys.First()))
            {
                foreach (var num in word.Value)
                {
                    Console.WriteLine($"{word.Key} -> {num.Key} times ({num.Value:f2}%)");
                }
            }

        }
    }
}





