using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, int> dictOFWords = new Dictionary<string, int>();

            for (int i = 0; i < sequence.Length; i++)
            {
                if (!dictOFWords.ContainsKey(sequence[i]))
                {
                    dictOFWords.Add(sequence[i], 0);
                }
                dictOFWords[sequence[i]] += 1;

            }

            List<string> res = new List<string>();

            foreach (var word in dictOFWords.Where(x => x.Value % 2 != 0))
            {
                res.Add(word.Key);
            }
            Console.WriteLine($"{string.Join(", ", res)}");
        }
    }
}
