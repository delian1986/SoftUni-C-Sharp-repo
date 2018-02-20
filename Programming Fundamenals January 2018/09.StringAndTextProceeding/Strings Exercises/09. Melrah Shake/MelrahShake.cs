using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// This program removes first and last occurance of pattern in text.
/// After removal the middle char in pattern is removed.
/// We do the loop again.
/// https://judge.softuni.bg/Contests/Compete/Index/321#8
/// </summary>

namespace _09._Melrah_Shake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (text.Length>=0&&pattern.Length>0)
            {
                //Index of first occurence.
                int firstIndex = text.IndexOf(pattern);
                //Index of last occurance.
                int lastIndex = text.LastIndexOf(pattern);


                if (firstIndex>=0&&lastIndex>=0&&firstIndex!=lastIndex)
                {
                    Console.WriteLine("Shaked it.");

                    text=text.Remove(firstIndex,pattern.Length);
                    lastIndex=text.LastIndexOf(pattern);
                    text=text.Remove(lastIndex,pattern.Length);

                    pattern=pattern.Remove(pattern.Length/2,1);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(text);

        }
    }
}
