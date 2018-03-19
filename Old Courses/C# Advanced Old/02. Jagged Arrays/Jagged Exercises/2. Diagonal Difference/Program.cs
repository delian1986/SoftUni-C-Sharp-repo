using System;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/573#1
/// </summary>
namespace _2._Diagonal_Difference
{
    class Program
    {
        static void Main()
        {
            int rows=int.Parse(Console.ReadLine());

            int[][]matrix=new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i]=Console.ReadLine().Split(new[]{" " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int primaryDiagonalSum=0;
            int colDiagonal=0;
            for (int row = 0; row < matrix.Length; row++)
            {
                primaryDiagonalSum+=matrix[row][colDiagonal];
                colDiagonal++;
            }

            colDiagonal=0;
            int secondDiagonalSum=0;
            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                secondDiagonalSum+=matrix[row][colDiagonal];
                colDiagonal++;
            }

            int difference=Math.Abs(primaryDiagonalSum-secondDiagonalSum);
            Console.WriteLine(difference);
        }
    }
}
