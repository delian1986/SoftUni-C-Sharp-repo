using System;
using System.Text;

/// <summary>
/// This program sum the count of 0 or 1 by a rule.
/// In the end it convert the sum in chars and print the result as 
/// string of characters.
/// https://judge.softuni.bg/Contests/Practice/Index/585#3
/// </summary>

namespace _04._Morse_Code_Upgraded
{
    class MorseCodeUpgraded
    {
        static void Main(string[] args)
        {
            string[] message = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            int sum = 0;
            StringBuilder result= new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                char[] subSequence = message[i].ToCharArray();

                for (int j = 0; j < subSequence.Length; j++)
                {
                    if (subSequence[j] == '0')
                    {
                        sum += 3;
                    }
                    else
                    {
                        sum += 5;
                    }
                    if (j > 0)
                    {
                        char prevNum = subSequence[j - 1];
                        if (prevNum == subSequence[j])
                        {
                            if (count == 0)
                            {
                                count++;
                            }
                            count++;
                        }

                        if (prevNum != subSequence[j] || j == subSequence.Length - 1)
                        {
                            sum += count;
                            count = 0;
                        }

                    }
                }
                result.Append((char)sum);
                sum=0;
            }

         Console.WriteLine(result.ToString());
        }

    }
}

