using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/433#1
/// </summary>

namespace _02._KeyKeyValueValue
{
    class KeyKeyValueValue
    {
        static void Main()
        {
            string queryKey=Console.ReadLine();
            string queryValue=Console.ReadLine();
            int numberOfLines=int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] kvp=Console.ReadLine().Split(new[]{" => ",";"},StringSplitOptions.RemoveEmptyEntries);
                string key=kvp[0];
                List<string>values=kvp.Skip(1).ToList();

                if (key.Contains(queryKey))
                {
                    Console.WriteLine($"{key}:");

                    foreach (var value in values)
                    {
                        if (value.Contains(queryValue))
                        {
                            Console.WriteLine($"-{value}");
                        }
                    }
                }
            }
        }
    }
}
