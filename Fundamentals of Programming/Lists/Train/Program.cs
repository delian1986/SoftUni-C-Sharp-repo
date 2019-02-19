using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main()
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string line = null;

            while ((line=Console.ReadLine())!="end")
            {
                string[] cmd = line.Split(" ");

                if (cmd.Length == 2)
                {
                    train.Add(int.Parse(cmd[1]));
                }
                else
                {
                    int passangersToFit = int.Parse(cmd[0]);
                    for (int i = 0; i < train.Count(); i++)
                    {
                        int sumOfPassangers = train[i] + passangersToFit;
                        if (sumOfPassangers<=maxCapacity)
                        {
                            train[i] = sumOfPassangers;
                            break;
                        }
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",train));

        }
    }
}
