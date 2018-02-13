using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string inputLine = String.Empty;
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while ((inputLine = Console.ReadLine()) != "END")
            {
                string[] args = inputLine.Split().ToArray();

                string action = args[0];
                string name = args[1];

                if (action == "A")
                {
                    string phoneNum = args[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phoneNum);
                    }
                    else
                    {
                        phonebook[name] = phoneNum;
                    }
                }
                else if (action == "S")
                {
                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        foreach (var phoneName in phonebook)
                        {
                            if (phoneName.Key == name)
                            {
                                Console.WriteLine($"{phoneName.Key} -> {phoneName.Value}");
                            }
                        }
                    }
                }
            }
        }
    }
}
