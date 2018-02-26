using System;
using System.IO;

/// <summary>
/// This program count occurencies in sequence of digits and write the 
/// most frequent numbers to onother file.
/// </summary>

namespace _01._Most_Frequent_Number
{
    class MostFrequentNumber
    {
        static void Main()
        {
            string[] nums = File.ReadAllLines("input.txt");



            for (int i = 0; i < nums.Length; i++)
            {
                string maxNum = string.Empty;
                int maxCount = 0;
                var line = nums[i].Split();

                for (int j = 0; j < line.Length; j++)
                {
                    string currNum = string.Empty;
                    int currCount = 1;
                    for (int k = j + 1; k < line.Length - 1; k++)
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
                File.AppendAllText("Output.txt", maxNum + Environment.NewLine);
            }
        }
    }
}
