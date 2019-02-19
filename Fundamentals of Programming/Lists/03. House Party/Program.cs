using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string cmd = Console.ReadLine();
                string[] args = cmd.Split(" ");
                string name = args[0];

                if (cmd.Contains("not"))
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                        continue;
                    }
                    Console.WriteLine($"{name} is not in the list!");

                }
                else
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    guests.Add(name);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,guests));
        }
    }
}
