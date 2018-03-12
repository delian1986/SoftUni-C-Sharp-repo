using System;
using System.Linq;

namespace _2._Square_With_Maximum_Sum
{
    class SquareWithMaximumSum
    {
        static void Main()
        {
            int[] args=Console.ReadLine().Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = args[0];
            int cols = args[1];
            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int maxSum=0;
            int currSum=0;
            int maxRow=0;
            int maxCol=0;

            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int col = 0; col < matrix[0].Length-1; col++)
                {
                    currSum=matrix[row][col]+matrix[row][col+1]+matrix[row+1][col]+matrix[row+1][col+1];
                    if (currSum>maxSum)
                    {
                        maxSum=currSum;
                        maxRow=row;
                        maxCol=col;
                    }
                }
            }
            Console.WriteLine("{0} {1}",matrix[maxRow][maxCol],matrix[maxRow][maxCol+1]);
            Console.WriteLine("{0} {1}",matrix[maxRow+1][maxCol],matrix[maxRow+1][maxCol+1]);
            Console.WriteLine(maxSum);
        }
    }
}
