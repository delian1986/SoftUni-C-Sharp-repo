using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/585#7
/// </summary>

namespace _08._Mines
{
    class Mines
    {
        static void Main()
        {
            string mineField = Console.ReadLine();
            mineField = MineExplosion(mineField);
            Console.WriteLine(mineField);
        }

        private static string MineExplosion(string mineField)
        {
            string mineDetectPattern = @"<([A-Za-z])([A-Za-z])>";
            foreach (Match mine in Regex.Matches(mineField, mineDetectPattern))
            {
                char firstComponent = char.Parse(mine.Groups[1].Value);
                char secondComponent = char.Parse(mine.Groups[2].Value);
                int explosionPower = Math.Abs(firstComponent - secondComponent);
                int indexOfMine = mine.Index;
                int startIndex = indexOfMine-explosionPower;
                if (startIndex<0)
                {
                    startIndex=0;
                }
                int explosionLength = indexOfMine + explosionPower+4;
                if (explosionLength>mineField.Length)
                {
                    explosionLength=mineField.Length;
                }
                string explosionField = mineField.Substring(startIndex, explosionLength-startIndex);
                string explosionResult = string.Concat(Enumerable.Repeat("_", explosionField.Length));

                mineField = mineField.Replace(explosionField,explosionResult);
            }
            return mineField;
        }

    }
}
