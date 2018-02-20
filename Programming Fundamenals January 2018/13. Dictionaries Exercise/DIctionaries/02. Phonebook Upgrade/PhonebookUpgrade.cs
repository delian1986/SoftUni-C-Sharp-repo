using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Phonebook_Upgrade
{
    class Program
    {
        static void Main()
        {
            string inputLine = String.Empty;
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while ((inputLine = Console.ReadLine()) != "END")
            {
                string[] args = inputLine.Split().ToArray();
                string action = args[0];

                if (action == "A")
                {
                    string name = args[1];
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
                    string name = args[1];

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
                else if (inputLine == "ListAll")
                {
                    foreach (var phoneNames in phonebook)
                    {
                        Console.WriteLine($"{phoneNames.Key} -> {phoneNames.Value}");
                    }
                }

            }
        }
    }
}
