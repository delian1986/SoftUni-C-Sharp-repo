using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Manipulate_Array
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[]command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "Reverse")
                {
                    sequence.Reverse();
                }
                else if (command[0] == "Distinct")
                {
                    List<string> unique = sequence.Distinct().ToList();
                    sequence = unique.ToList();

                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    string wordToReplace = command[2];
                    if (index < 0 || index > sequence.Count - 1)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        sequence = ReplacingString(command, sequence);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
            Console.WriteLine(string.Join(", ", sequence));

        }

        private static List<string> ReplacingString(string[] command, List<string> sequence)
        {
            int index = int.Parse(command[1]);
            string wordToReplace = command[2];
            sequence.RemoveAt(index);
            sequence.Insert(index, wordToReplace);
            return sequence;
        }
    }
}
