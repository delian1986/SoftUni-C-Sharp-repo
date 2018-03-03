using System;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/455#1
/// </summary>

namespace _02._Command_Interpreter
{
    class Program
    {
        static void Main()
        {
            string[] sequence = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = args[0];

                if (command == "reverse")
                {
                    int start = int.Parse(args[2]);
                    int count = int.Parse(args.Last());
                    bool isValid = ValidatingIndexes(start, count, sequence.Length);
                    if (!isValid)
                    {
                        continue;
                    }

                    sequence = Reverse(start, count, sequence);
                }
                else if (command == "sort")
                {
                    int start = int.Parse(args[2]);
                    int count = int.Parse(args.Last());
                    bool isValid = ValidatingIndexes(start, count, sequence.Length);
                    if (!isValid)
                    {
                        continue;
                    }

                    sequence = Sort(start, count, sequence);

                }
                else if (command == "rollRight")
                {
                    int countTimes = int.Parse(args[1]);
                    bool isValid=ValidatingRollCount(countTimes);
                    if (!isValid)
                    {
                        continue;
                    }
                    sequence = RollRight(countTimes, sequence);
                }
                else if (command == "rollLeft")
                {
                    int countTimes = int.Parse(args[1]);
                     bool isValid=ValidatingRollCount(countTimes);
                    if (!isValid)
                    {
                        continue;
                    }
                    sequence=RollLeft(countTimes,sequence);
                }
            }

            Console.WriteLine("[" + string.Join(", ", sequence) + "]");
        }

        private static bool ValidatingRollCount(int countTimes)
        {
            if (countTimes<0)
            {
                Console.WriteLine("Invalid input parameters.");

                return false;
            }
            else
            {
                return true;
            }
        }

        private static string[] RollLeft(int countTimes, string[] sequence)
        {
            //1 2 3 4 5 <-
            countTimes%=sequence.Length;
            string[]firstPart=sequence.Take(countTimes).ToArray();
            string[]secondPart=sequence.Skip(countTimes).ToArray();
            return secondPart.Concat(firstPart).ToArray();
        }

        private static string[] RollRight(int countTimes, string[] sequence)
        {
            //1 2 3 4 5 ->
            countTimes%=sequence.Length;
            string[]firstPart=sequence.Take(sequence.Length-countTimes).ToArray();
            string[]secondPart=sequence.Skip(sequence.Length-countTimes).ToArray();
            return secondPart.Concat(firstPart).ToArray();
        }

        private static string[] Sort(int start, int count, string[] sequence)
        {
            string[]firstPart=sequence.Take(start).ToArray();
            string[]sortedPart=sequence.Skip(start).Take(count).OrderBy(x=>x).ToArray();
            string[]lastPart=sequence.Skip(start+count).ToArray();
            return firstPart.Concat(sortedPart).Concat(lastPart).ToArray();
        }

        private static string[] Reverse(int start, int count, string[] sequence)
        {
            string[]firstPart=sequence.Take(start).ToArray();
            string[]reversedPart=sequence.Skip(start).Take(count).Reverse().ToArray();
            string[]lastPart=sequence.Skip(start+count).ToArray();
            return firstPart.Concat(reversedPart).Concat(lastPart).ToArray();
        }

        private static bool ValidatingIndexes(int start, int count, int seqCount)
        {
            bool isValid = true;

            if (start < 0 || start >= seqCount || start + count < 0 || start + count-1 >= seqCount)
            {
                Console.WriteLine("Invalid input parameters.");
                return isValid = false;
            }
            else
            {
                return isValid;
            }
        }
    }
}
