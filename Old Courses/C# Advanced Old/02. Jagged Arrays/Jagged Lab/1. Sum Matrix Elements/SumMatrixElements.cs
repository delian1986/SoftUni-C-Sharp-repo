using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class SumMatrixElements
    {
        static void Main()
        {
            int[] args=Console.ReadLine().Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = args[0];
            int cols = args[1];
            int sum=0;
            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sum+=matrix[row].Sum();
            }

            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix[0].Length);
            Console.WriteLine(sum);
        }
    }
}
