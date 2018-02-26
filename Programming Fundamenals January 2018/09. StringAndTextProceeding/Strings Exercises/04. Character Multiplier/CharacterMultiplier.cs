using System;

/// <summary>
/// This program multiplay chars of two words one by one and print the result.
/// https://judge.softuni.bg/Contests/Compete/Index/321#3
/// </summary>

namespace _04._Character_Multiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[]input=Console.ReadLine().Split();
            string wordOne=input[0];
            string wordTwo=input[1];

            int sum=0;

            for (int i = 0; i < Math.Min(wordOne.Length,wordTwo.Length); i++)
            {
                sum+=wordTwo[i]*wordOne[i];
            }

            for (int i = Math.Min(wordOne.Length,wordTwo.Length); i < Math.Max(wordTwo.Length,wordOne.Length); i++)
            {
                try
                {
                    sum+=wordOne[i];
                }
                catch
                {
                    sum+=wordTwo[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
