using System;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/573#2
/// </summary>

namespace _3._Squares_in_Matrix
{
    class Program
    {
        static void Main()
        {
            int[] args=Console.ReadLine().Split(new[]{" " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows=args[0];
            int cols=args[1];

            char[][]jagged=new char[rows][];

            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i]=Console.ReadLine().Split(new[]{ ' '},StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }

            int squareEqual=0;
            for (int row = 0; row < jagged.Length-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    if (jagged[row][col]==jagged[row+1][col+1]&&jagged[row][col+1]==jagged[row+1][col]&&jagged[row+1][col]==jagged[row][col])
                    {
                        squareEqual++;
                    }
                }
            }
            Console.WriteLine(squareEqual);
        }
    }
}
