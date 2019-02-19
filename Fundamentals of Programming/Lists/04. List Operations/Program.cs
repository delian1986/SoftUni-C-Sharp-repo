using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = String.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] cmd = line.Split(" ");

                if (cmd[0] == "Add")
                {
                    list.Add(int.Parse(cmd[1]));
                }
                else if (cmd[0] == "Remove")
                {
                    int index = int.Parse(cmd[1]);

                    if (index >= 0 && index <= list.Count() - 1)
                    {
                        list.RemoveAt(index);
                        continue;
                    }

                    Console.WriteLine("Invalid index");
                }
                else if (cmd[0] == "Insert")
                {
                    int value = int.Parse(cmd[1]);
                    int index = int.Parse(cmd[2]);

                    if (index >= 0 && index <= list.Count() - 1)
                    {
                        list.Insert(index, value);
                        continue;
                    }
                    Console.WriteLine("Invalid index");

                }
                else if (cmd[1] == "left")
                {
                    for (int i = 0; i < int.Parse(cmd[2]); i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else
                {
                    for (int i = 0; i < int.Parse(cmd[2]); i++)
                    {
                        list.Insert(0, list[list.Count - 1]);
                        list.RemoveAt(list.Count - 1);

                    }
                }
            }

            Console.WriteLine(string.Join(" ", list));

        }
    }
}
