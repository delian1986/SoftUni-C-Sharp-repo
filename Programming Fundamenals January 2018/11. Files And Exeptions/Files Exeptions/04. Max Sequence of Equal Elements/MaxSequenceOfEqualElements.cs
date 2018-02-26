using System;
using System.IO;
using System.Linq;

/// <summary>
/// This program count max number of equals.
/// </summary>

namespace _04._Max_Sequence_of_Equal_Elements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
              string[] nums = File.ReadAllLines("input.txt");

            for (int i = 0; i < nums.Length; i++)
            {
                string maxNum = string.Empty;
                int maxCount = 0;
                var line = nums[i].Split();

                for (int j = 0; j < line.Length-1; j++)
                {
                    string currNum = string.Empty;
                    int currCount = 1;
                    for (int k = j + 1; k < line.Length; k++)
                    {
                        if (line[j] == line[k])
                        {
                            currNum = line[j];
                            currCount++;

                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                maxNum = currNum;
                            }
                        }
                    }
                }
                File.AppendAllText("Output.txt", string.Concat(Enumerable.Repeat(maxNum+" ",maxCount)) + Environment.NewLine);
            }
        }
    }
}
