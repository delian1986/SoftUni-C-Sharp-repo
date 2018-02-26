using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// 80/100
/// https://judge.softuni.bg/Contests/Practice/Index/582#6
/// </summary>

namespace _07._Take_Skip_Rope
{
    class Program
    {
        static void Main()
        {
            string input= Console.ReadLine();

            string patternForLetters=@"[A-Za-z_]+";
            string patternForNums=@"\d+";

            string nums=string.Empty;
            string letters=string.Empty;

            List<string>letterList= new List<string>();

            foreach (Match num in Regex.Matches(input,patternForNums))
            {
                nums+=num;
            }

            foreach (Match letter in Regex.Matches(input,patternForLetters))
            {
                letters+=letter;
            }

            List<int> takeList=new List<int>();
            List<int> skipList=new List<int>();

            for (int i = 0; i < nums.ToCharArray().Length; i++)
            {
                if (i%2==0)
                {
                    takeList.Add(nums[i]);
                }
                else
                {
                    skipList.Add(nums[i]);
                }
            }

            int totalSkip = 0;
            string finalMessage = String.Empty;
 
            for (int i = 0; i < takeList.Count; i++)
            {
                int takeCount = takeList[i];
                int skipCount = skipList[i];
 
                finalMessage += new string(
                    letters.Skip(totalSkip).
                    Take(takeCount).ToArray());
 
                totalSkip += takeCount + skipCount;
            }
 
            Console.WriteLine(finalMessage);

        }
    }
}
