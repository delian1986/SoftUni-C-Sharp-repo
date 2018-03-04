using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// </summary>

namespace _02
{
    class Sequence
    {
        private long[] _name;

        public long Length { get; set; }
        public long SumOfOnes { get; set; }
        public long StartIndex { get; set; }
        public long[] Name { get => _name; set => _name = value; }
        public long NumberByRoll { get; set; }
    }

    class Program
    {
        static void Main()
        {
            long seqLength = long.Parse(Console.ReadLine());
            string input = string.Empty;
            List<Sequence> allSequences = new List<Sequence>();
            long dnaNumber = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {

                dnaNumber++;
                long[] sequence = input.Split(new[]{'!',' '},StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

                Sequence current = new Sequence();

                long longest = 0;
                long length = 1;
                long i;
                long last = 0;

                for (i = 1; i < sequence.Length; i++)
                {
                    if (sequence[i] == sequence[i - 1] && sequence[i] == 1 && sequence[i - 1] == 1)
                    {
                        length++;
                    }
                    else
                    {
                        if (length > longest)
                        {
                            longest = length;
                        }
                        length = 1;
                    }

                    if (length > longest)
                    {

                        longest = length;
                        last = i;
                    }
                }

                //Forming curren sequence properties and adds it to list.
                current.Name = sequence;
                current.Length = longest;
                current.StartIndex = last - longest + 1;
                current.SumOfOnes = sequence.Where(x => x == 1).Sum();
                current.NumberByRoll = dnaNumber;
                allSequences.Add(current);
            }

            var orderedByBest = allSequences.OrderByDescending(x => x.Length)
                .ThenBy(x => x.StartIndex)
                .ThenByDescending(x => x.SumOfOnes)
                .First();

            Console.WriteLine($"Best DNA sample {orderedByBest.NumberByRoll} with sum: {orderedByBest.SumOfOnes}.");
            Console.WriteLine($"{string.Join(" ", orderedByBest.Name)}");
        }
    }
}

