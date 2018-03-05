using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/433#3
/// 100/100
/// </summary>
namespace _04._Shellbound
{
    class Shellbound
    {
        static void Main()
        {
            Dictionary <string,HashSet<int>> vladiShells=new Dictionary<string, HashSet<int>>();

            string input=string.Empty;

            while ((input=Console.ReadLine())!="Aggregate")
            {
                string[]args=input.Split(new[]{ ' '},StringSplitOptions.RemoveEmptyEntries);

                string region=args[0];
                int size=int.Parse(args[1]);

                if (!vladiShells.ContainsKey(region))
                {
                    vladiShells.Add(region,new HashSet<int>());
                }
                vladiShells[region].Add(size);
            }

            foreach (var region in vladiShells)
            {
                string shellValues=string.Join(", ",region.Value);
                int giantShell=region.Value.Sum()-(region.Value.Sum()/region.Value.Count);
                Console.WriteLine($"{region.Key} -> {shellValues} ({giantShell})");
            }
        }
    }
}
