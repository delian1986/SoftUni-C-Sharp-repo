using System;
using System.Linq;

namespace _0._PlayGround
{
    class Program
    {
        static void Main()
        {
            int[][] matrix = new int[4][];

            //fill matrix
            int number = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[4];
                for (int col = 0; col < 4; col++)
                {
                    matrix[row][col] = ++number;
                }
            }

            int 
            //swap rows
            //swap row 0 with row 3
            int[] tempArrayRowZero = new int[4];
            int[] tempArrayRowThree = new int[4];
            int[][] swapedRowsMatrix = new int[4][];
            tempArrayRowZero = matrix[0];
            tempArrayRowThree = matrix[3];
            swapedRowsMatrix[0] = tempArrayRowThree;
            swapedRowsMatrix[3] = tempArrayRowZero;

            //swap columns
            //swap col 0 with col 2
            int[][] swapedColsMatrix = matrix.ToArray();

            int[] tempArrColZero = new int[4];
            int[] tempArrColTwo = new int[4];
            int i = 0;
            for (int row = 0; row < matrix.Length; row++, i++)
            {
                tempArrColZero[i] = matrix[row][0];
                tempArrColTwo[i] = matrix[row][2];
            }
            i = 0;
            for (int row = 0; row < matrix.Length; row++,i++)
            {
                swapedColsMatrix[row][0] = tempArrColTwo[i];
                swapedColsMatrix[row][2] = tempArrColZero[i];
            }

        }
    }
}
