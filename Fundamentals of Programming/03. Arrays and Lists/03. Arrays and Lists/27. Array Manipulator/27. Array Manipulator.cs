using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayManiupulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        input.Insert(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "addMany":
                        List<int> range = new List<int>();
                        for (int i = 2; i < command.Length; i++)
                        {
                            range.Add(int.Parse(command[i]));
                        }
                        input.InsertRange(int.Parse(command[1]), range);
                        break;
                    case "contains":
                        if (input.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine(input.IndexOf(int.Parse(command[1])));
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;
                    case "remove":
                        input.RemoveAt(int.Parse(command[1]));
                        break;
                    case "shift":
                        for (int k = 0; k < int.Parse(command[1]); k++)
                        {
                            int firstElement = input[0];
                            for (int i = 0; i < input.Count - 1; i++)
                            {
                                input[i] = input[i + 1];
                            }
                            input[input.Count - 1] = firstElement;
                        }
                        break;
                    case "sumPairs":
                        List<int> sumPairs = new List<int>();
                        if (input.Count % 2 == 0)
                        {
                            for (int i = 0; i < input.Count; i += 2)
                            {
                                int sum = input[i] + input[i + 1];
                                sumPairs.Add(sum);
                            }
                            input = sumPairs;
                        }
                        else
                        {
                            input.Add(0);
                            for (int i = 0; i < input.Count; i += 2)
                            {
                                int sum = input[i] + input[i + 1];
                                sumPairs.Add(sum);
                            }
                            input = sumPairs;
                        }

                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.Write("[");
            Console.Write(string.Join(", ", input));
            Console.WriteLine("]");
        }
    }
}