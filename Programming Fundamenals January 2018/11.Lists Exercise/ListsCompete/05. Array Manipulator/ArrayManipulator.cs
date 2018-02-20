using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    int index = int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    sequence.Insert(index, element);
                }
                else if (command[0] == "addMany")
                {
                    int index = int.Parse(command[1]);

                    List<int> addElements = new List<int>();
                    for (int i = 2; i < command.Length; i++)
                    {
                        addElements.Add(int.Parse(command[i]));
                    }

                    sequence.InsertRange(index, addElements);
                }
                else if (command[0] == "contains")
                {
                    int numToCheck = int.Parse(command[1]);
                    if (sequence.Contains(numToCheck))
                    {
                        Console.WriteLine(sequence.IndexOf(numToCheck));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (command[0] == "sumPairs")
                {
                    var summedPairs = new List<int>();

                    if (sequence.Count % 2 == 0)
                    {
                        for (int i = 0; i < sequence.Count; i += 2)
                        {
                            summedPairs.Add(sequence[i] + sequence[i + 1]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < sequence.Count - 1; i += 2)
                        {
                            summedPairs.Add(sequence[i] + sequence[i + 1]);
                        }
                        summedPairs.Add(sequence[sequence.Count - 1]);
                    }
                    sequence.Clear();
                    sequence = summedPairs.ToList();
                }
                else if (command[0] == "shift")
                {
                    int positions = int.Parse(command[1]);

                    for (int i = 0; i < positions; i++)
                    {
                        int last = sequence[0];
                        for (int j = 0; j < sequence.Count - 1; j++)
                        {
                            sequence[j]=sequence[j+1];
                        }
                        sequence[sequence.Count-1]=last;
                    }
                }
                else if (command[0]=="remove")
                {
                    int elementToRemove=int.Parse(command[1]);
                    sequence.RemoveAt(elementToRemove);
                }

                command = Console.ReadLine().Split();
            }

            Console.Write("[");
            Console.Write(string.Join(", ", sequence));
            Console.WriteLine("]");
        }
    }
}
