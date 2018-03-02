using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 80/100
/// https://judge.softuni.bg/Contests/Practice/Index/834#1
/// </summary>

namespace _02._Anonymous_Threat
{
    class AnonymousThreat
    {
        static void Main()
        {
            List<string> sequence = Console.ReadLine().Split().ToList();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "3:1")
            {
                List<string> current = new List<string>();
                string[] args = line.Split();
                string command = args[0];
                int startPosition = int.Parse(args[1]);
                int endPosition = int.Parse(args[2]);

                if (command == "merge")
                {
                    if (startPosition < 0)
                    {
                        startPosition = 0;
                    }
                    else if (startPosition > sequence.Count - 1)
                    {
                        startPosition = sequence.Count - 1;
                    }

                    if (endPosition < 0)
                    {
                        endPosition = 0;
                    }
                    else if (endPosition > sequence.Count - 1)
                    {
                        endPosition = sequence.Count - 1;
                    }

                    string merged = string.Empty;
                    for (int i = startPosition; i <= endPosition; i++)
                    {
                        merged += sequence[i];
                    }

                    for (int i = startPosition; i <= endPosition; i++)
                    {
                        sequence.RemoveAt(startPosition);
                    }
                    sequence.Insert(startPosition, merged);


                }
                else if (command == "divide")
                {
                    int index = startPosition;
                    int parts = endPosition;
                    int wordLength = sequence[index].Length / parts;

                    List<string> divided = new List<string>();

                    while (sequence[index].Length >= wordLength)
                    {
                        string element = sequence[index].Substring(0, wordLength);
                        divided.Add(element);
                        sequence[index] = sequence[index].Substring(wordLength);
                    }

                    if (sequence[index] != "")
                    {
                        divided.Add(sequence[index]);
                    }

                    if (divided[divided.Count - 1].Length != wordLength)
                    {
                        var concatLast = divided[divided.Count - 2] + divided[divided.Count - 1];

                        divided.RemoveRange(divided.Count - 2, 2);
                        divided.Add(concatLast);
                    }
                    sequence.RemoveAt(index);
                    sequence.InsertRange(index, divided);
                }

            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
